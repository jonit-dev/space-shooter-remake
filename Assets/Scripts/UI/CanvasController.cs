using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private Text text;

    [SerializeField]
    private PlayerController player;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = $"Score : {player.playerScore.Score}";
    }
}
