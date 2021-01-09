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

    private bool _hasShield = false;



    [SerializeField]
    private ShieldEffectController _shieldPrefab;

    private ShieldEffectController _shieldInstance;

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
        if (!_hasShield) // if we don't have a shield!
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

    public void ActivateShield()
    {

        Debug.Log("Activating player shield!");

        _shieldInstance = Instantiate(_shieldPrefab, transform.position, Quaternion.identity);
        _shieldInstance.player = player;

        _hasShield = true;
        StartCoroutine(RemoveShield()); // wait for 10 secs before disabling again!
    }

    private IEnumerator RemoveShield()
    {
        yield return new WaitForSeconds(10f);

        _hasShield = false;
        Debug.Log("Disabling player shield");
        _shieldInstance.Disable();
    }



}
