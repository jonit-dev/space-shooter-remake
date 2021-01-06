using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{

    [SerializeField]
    private int _speed = 3;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        //Move down using power up _speed
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        float yPos = transform.position.y;

        if (yPos < -5)
        {
            Debug.Log("Destroying power up - out of screen!");
            Destroy(this.gameObject);
        }

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag);

        if (other.gameObject.tag == "Player")
        {

            Destroy(this.gameObject);

            Debug.Log("Power up for triple shot activated!");
        }
    }
}
