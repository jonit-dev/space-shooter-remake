using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaser : MonoBehaviour
{

    [SerializeField]
    private Player player;


    [SerializeField]
    private GameObject _laserPrefab;

    [SerializeField]
    private float _fireRate = 0.5f;
    private float _nextFire = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.Space) && (Time.time > _nextFire))
        {
            _nextFire = Time.time + _fireRate;

            // instantiate new laser beam, 0.8 Y offset to the top
            GameObject laser = Instantiate(_laserPrefab, transform.position + new Vector3(0, 0.8f, 0), Quaternion.identity);
        }

    }
}
