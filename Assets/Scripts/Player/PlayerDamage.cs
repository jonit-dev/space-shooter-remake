using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{

    [SerializeField]
    private PlayerController playerController;

    [SerializeField]
    private int _lives = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void Damage()
    {
        _lives -= 1;
        Debug.Log("Removing 1 player life! Total: " + _lives);

        if (_lives < 1)
        {
            Destroy(this.gameObject);
        }
    }



}
