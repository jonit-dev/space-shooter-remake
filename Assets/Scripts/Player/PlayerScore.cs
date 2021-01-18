using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private PlayerController player;

    private int _score;

    public int Score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
            player.canvas.UpdateScore();
        }
    }

    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }


}
