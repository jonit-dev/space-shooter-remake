﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUpController : MonoBehaviour
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
            player.playerMovement.SpeedBoost(); //active speed boost!
        }

    }




}
