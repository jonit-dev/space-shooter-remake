using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    [SerializeField]
    private float _moveSpeed = 1.5f;

    private PlayerController _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _moveSpeed * Time.deltaTime);

        if (transform.position.y <= -6)
        {
            float randomX = Random.Range(-9f, 9f);
            transform.position = new Vector3(randomX, 6, 0); // reset initial position, with random x, if goes out of bounds on Y
        }

    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        switch (other.gameObject.tag)
        {
            case "ShieldEffect":

                // Deactivate player's shield
                ShieldEffectController shield = other.transform.GetComponent<ShieldEffectController>();
                _player.playerDamage.ShieldDeactivate();
                Destroy(gameObject); //self destroy

                break;
            case "Player":
                // if other is player, then destroy us and damage player
                //! Player damage code to be added

                if (_player != null)
                {
                    _player.playerDamage.Damage();
                }
                Destroy(gameObject);

                break;

            case "Laser":

                if (_player != null)
                {
                    _player.playerScore.Score += 10;
                    Destroy(other.gameObject); //destroy the laser
                    // if other is laser, destroy us and destroy laser;
                    Destroy(gameObject);
                }


                break;

        }



    }

}
