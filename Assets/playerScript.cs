using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float speed; 
    private Vector3 direction;

    public gameOverScreen gameOverScreen;
    public int score;
    public TextMeshProUGUI scoreText;
    public AudioSource bounceSound;
    public AudioSource loseSound;
    bool hasPlayedSound = false;

    public void gameOver()
    {
        gameOverScreen.SetUp(score);
    }

    void Start()
    {
        float randomX = Random.value < 0.5f ? -1f : 1f; 
        direction = new Vector3(randomX, -1f, 0f).normalized;
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;

        
        if (gameObject.transform.position.y <= -3 && !hasPlayedSound)
        {
            loseSound.Play();
            hasPlayedSound = true;
            scoreText.text = "";
            gameOver();
        }

        if (Time.timeSinceLevelLoad >= 10f && Time.timeSinceLevelLoad % 10f < Time.deltaTime)
        {
            speed += 2;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 newDirection = Vector3.Reflect(direction, collision.contacts[0].normal);
        direction = newDirection.normalized;
        
        if (collision.transform.tag == "bottomWall")
        {
            score += 1;
            scoreText.text = score.ToString() + " POINTS";
        }

        if (collision.transform.tag == "obstacle")
        {
            loseSound.Play();
            scoreText.text = "";
            gameOver();
        }
        else
        {
            bounceSound.Play();
        }
    }
}
