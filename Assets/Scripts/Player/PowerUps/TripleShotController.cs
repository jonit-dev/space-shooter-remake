using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleShotController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "ShieldEffect")
        {
            // Enable power up and destroy self
            PlayerController player = other.transform.GetComponent<PlayerController>();
            if (player)
            {
                player.playerLaser.ActivateTripleShot();
            }
        }
    }
}
