﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    internal PlayerLaser playerLaser;

    [SerializeField]
    internal PlayerMovement playerMovement;

    [SerializeField]
    internal PlayerDamage playerDamage;

    [SerializeField]
    internal PlayerItem playerItem;

    [SerializeField]
    internal PlayerScore playerScore;

    [SerializeField]
    public CanvasController canvas;


    private void Awake() //before start
    {

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
