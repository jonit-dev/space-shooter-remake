using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUpSpawnController : MonoBehaviour
{

    [SerializeField]
    private GameObject _tripleShotPref;

    [SerializeField]
    private GameObject _speedBoostPrefab;

    [SerializeField]
    private GameObject _shieldPrefab;

    [SerializeField]
    private GameObject _powerUpContainer;

    private Coroutine _spawnInterval;

    private GameObject[] _powerUps;

    // Start is called before the first frame update
    void Start()
    {

        // Add it to somewhere like the Start() method
        _spawnInterval = StartCoroutine(SpawnInternal());

        _powerUps = new GameObject[] { _tripleShotPref, _shieldPrefab, _speedBoostPrefab };


    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator SpawnInternal()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);


            Debug.Log(_powerUps);


            Vector3 spawnPosition = new Vector3(Random.Range(-9f, 9f), 0, 0);

            System.Random r = new System.Random();

            GameObject newPowerUp = Instantiate(_powerUps[r.Next(0, _powerUps.Length)], transform.position + spawnPosition, Quaternion.identity);
            newPowerUp.transform.parent = _powerUpContainer.transform;
            Debug.Log("Spawning power up!");
        }
    }

    public void StopSpawningPowerUps()
    {
        Debug.Log("Player is dead. Stop spawning!");
        StopCoroutine(_spawnInterval);
    }


}
