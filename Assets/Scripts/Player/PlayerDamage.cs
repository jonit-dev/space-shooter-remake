using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{

    [SerializeField]
    private PlayerController player;

    [SerializeField]
    private int _lives = 3;


    private EnemySpawnController _enemySpawn;

    // Start is called before the first frame update
    void Start()
    {
        _enemySpawn = GameObject.Find("EnemySpawn").GetComponent<EnemySpawnController>();

        if (_enemySpawn == null)
        {
            Debug.LogError("Spawn manager not found");
        }

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void Damage()
    {
        _lives -= 1;
        Debug.Log("Removing 1 player life! Total: " + _lives);

        if (_lives < 1)
        {
            _enemySpawn.StopSpawningEnemies(); // stop spawning enemies, on player's death
            Destroy(this.gameObject);
        }
    }



}
