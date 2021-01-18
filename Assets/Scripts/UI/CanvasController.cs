using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private Text _uiScoreText;

    [SerializeField]
    private PlayerController player;

    [SerializeField]
    private Sprite[] _liveSprites;

    [SerializeField]
    private Image _uiLivesImage;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void UpdateLives()
    {
        _uiLivesImage.sprite = _liveSprites[player.playerDamage.lives];
    }

    public void UpdateScore()
    {
        _uiScoreText.text = $"Score: {player.playerScore.Score}";
    }
}
