using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{

    [SerializeField]
    private GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnInterval());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator SpawnInterval()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            GameObject newEnemy = Instantiate(enemy, transform.position + new Vector3(Random.Range(-9f, 9f), 0, 0), Quaternion.identity);
            // Debug.Log("Spawning enemy!");
        }
    }
}
