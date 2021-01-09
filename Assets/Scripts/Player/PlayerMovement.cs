using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private PlayerController player;

    [SerializeField]
    private float _moveSpeed = 3.5f;

    private float _movementX;
    private float _movementY;

    private bool _hasSpeedBoost = false;
    private float _speedBoost = 1.5f;




    void Start()
    {
        // transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // movement
        calculateMovement();

        // Constraints
        wrapHorizontally();
        clampMovementOutsideBoundaries(-9, 9, -4, 4);
    }

    void calculateMovement()
    {
        _movementX = Input.GetAxisRaw("Horizontal");
        _movementY = Input.GetAxisRaw("Vertical");


        Vector3 direction = new Vector3(_movementX, _movementY, 0);
        //move in meters/second (real time), to a specified vector direction.

        // if player has speed boost, increase its speed!
        transform.Translate(direction * (_hasSpeedBoost ? (_moveSpeed * _speedBoost) : _moveSpeed) * Time.deltaTime);

    }

    void clampMovementOutsideBoundaries(float xMin, float xMax, float yMin, float yMax)
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax), Mathf.Clamp(transform.position.y, yMin, yMax), 0);
    }

    void wrapHorizontally()
    {
        if (transform.position.x > 11)
        {
            transform.position = new Vector3(-11, transform.position.y, 0);
        }
        else if (transform.position.x < -11)
        {
            transform.position = new Vector3(11, transform.position.y, 0);
        }
    }

    private IEnumerator SetSpeedBackToNormal()
    {

        yield return new WaitForSeconds(10f);

        player.playerMovement._hasSpeedBoost = false;
        Debug.Log("Disabling player speed boost!");


    }

    public void SpeedBoost()
    {

        _hasSpeedBoost = true;

        StartCoroutine(SetSpeedBackToNormal()); // wait for 5 secs before disabling again!
    }

}
