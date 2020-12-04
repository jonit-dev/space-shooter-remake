using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float _moveSpeed = 3.5f;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        float movementX = Input.GetAxisRaw("Horizontal");
        float movementY = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(movementX, movementY, 0);


        transform.Translate(movement * _moveSpeed * Time.deltaTime); //5 meters/second (real time), to a specified vector direction.
    }
}
