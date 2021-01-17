using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldEffectController : MonoBehaviour
{


    public PlayerController player;

    private float _scaleMin = 0.47f;
    private float _scaleMax = 0.53f;
    private float _scaleStep = 0.0025f;

    private string _animDirection = "Grow";



    // Start is called before the first frame update
    void Start()
    {
        if (player)
        {
            transform.parent = player.transform;
        }

    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, 0, 0.25f, Space.Self);

        // Growing animation

        switch (_animDirection)
        {
            case "Grow":

                transform.localScale += new Vector3(_scaleStep, _scaleStep, _scaleStep);

                if (transform.localScale.x >= _scaleMax)
                {
                    _animDirection = "Reduce";
                }

                break;
            case "Reduce":

                transform.localScale += new Vector3(-_scaleStep, -_scaleStep, -_scaleStep);

                if (transform.localScale.x <= _scaleMin)
                {
                    _animDirection = "Grow";
                }
                break;
        }

    }

    public void Disable()
    {
        if (this.gameObject)
        {
            Debug.Log("Disabling shield effect");
            Destroy(this.gameObject);
        }
    }
}
