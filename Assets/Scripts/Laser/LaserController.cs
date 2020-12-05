using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{

    [SerializeField]
    private int _moveSpeed = 15;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * _moveSpeed);

        if (transform.position.y >= 6) // after it overflows the world boundary area, just remove it to increase game performance
        {
            Destroy(this.gameObject);
        }

    }
}
