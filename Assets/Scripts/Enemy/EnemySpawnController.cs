using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{

    [SerializeField]
    private GameObject _enemyPrefab;

    [SerializeField]
    private GameObject _enemyContainer;

    private IEnumerator _spawnCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        _spawnCoroutine = SpawnInterval();
        StartCoroutine(_spawnCoroutine);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator SpawnInterval()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            Vector3 spawnPosition = new Vector3(Random.Range(-9f, 9f), 0, 0);
            GameObject newEnemy = Instantiate(_enemyPrefab, transform.position + spawnPosition, Quaternion.identity);
            newEnemy.transform.parent = _enemyContainer.transform;
            // Debug.Log("Spawning enemy!");
        }

    }

    public void StopSpawningEnemies()
    {
        Debug.Log("Player is dead. Stop spawning!");
        StopCoroutine(_spawnCoroutine);
    }
}
