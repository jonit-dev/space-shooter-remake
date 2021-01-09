using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaser : MonoBehaviour
{

    [SerializeField]
    private PlayerController player;


    [SerializeField]
    private GameObject _laserPrefab;

    [SerializeField]
    private GameObject _laserTripleShotPrefab;

    [SerializeField]
    private float _fireRate = 0.5f;
    private float _nextFire = 0.0f;

    private bool _hasTripleShot = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        FireLaser();


    }


    void FireLaser()
    {

        if (Input.GetKey(KeyCode.Space) && (Time.time > _nextFire))
        {
            _nextFire = Time.time + _fireRate;

            if (_hasTripleShot)
            {
                GameObject tripleShotLaser = Instantiate(_laserTripleShotPrefab, transform.position + new Vector3(-0.2f, -0.3f, 0), Quaternion.identity);
            }
            else
            {
                // instantiate new laser beam, 0.8 Y offset to the top
                GameObject laser = Instantiate(_laserPrefab, transform.position + new Vector3(0, 0.8f, 0), Quaternion.identity);

            }

        }

    }

    public void ActivateTripleShot()
    {
        _hasTripleShot = true;
        StartCoroutine(DisableTripleShot());

    }

    private IEnumerator DisableTripleShot()
    {

        yield return new WaitForSeconds(10f);
        _hasTripleShot = false;

    }


}
