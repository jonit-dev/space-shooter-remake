using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
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
        Debug.Log(other.gameObject.tag);

        if (other.gameObject.tag == "Player")
        {
            // Enable power up and destroy self
            PlayerController player = other.transform.GetComponent<PlayerController>();
            player.playerLaser.hasTripleShot = true;

            Destroy(this.gameObject);

            Debug.Log("Power up for triple shot activated!");
        }
    }
}
