using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPowerUpController : MonoBehaviour
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
        PlayerController player = other.transform.GetComponent<PlayerController>();
        if (player)
        {
            if (!player.playerDamage.hasShield) // if theres no shield currently available!
            {
                player.playerDamage.ActivateShield();
            }
        }

    }
}
