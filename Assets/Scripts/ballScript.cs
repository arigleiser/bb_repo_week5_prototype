using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ballScript : MonoBehaviour
{
    public float initialSpeed;
    public float speed;
    public float speedIncreaseRate;
    public float countdown;
    public float tempcountdown;
    public AudioSource bounceSound;
    public Rigidbody2D rb;
    Vector3 lastVelocity;
    // public cameraShake cs;


    public TMP_Text disvar;

    public gameOverScreen gameOverScreen;
    public int score;
    public TextMeshProUGUI scoreText;

    public void gameOver()
    {
        gameOverScreen.SetUp(score);
    }

    void Start()
    {
        tempcountdown = countdown;
        speed = initialSpeed;
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(60 * Time.deltaTime * speed, 60 * Time.deltaTime * speed));
        score = 0;
        scoreText.text = score.ToString() + " POINTS";
    }

    void Update()
    {
        if (gameObject.transform.position.y <= -3.4)
        {
            scoreText.text = "";
            gameOver();
        }

        lastVelocity = rb.velocity;
        if (tempcountdown > 0)
        {
            tempcountdown -= Time.deltaTime;
        }

        else if (tempcountdown <= 0)
        {
            tempcountdown = countdown;
            speed += speedIncreaseRate;
            rb.AddForce(new Vector2(20 * Time.deltaTime * speed, 20 * Time.deltaTime * speed));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bounceSound.Play();
        var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
        rb.velocity = direction * lastVelocity.magnitude;

        if (collision.transform.tag == "bottomWall")
        {
            rb.AddForce(new Vector2(2 * Time.deltaTime * speed, 2 * Time.deltaTime * speed));
            score += 1;
            scoreText.text = score.ToString() + " POINTS";
        }

        if (collision.transform.tag == "obstacle")
        {
            // cs.ShakeCamera();
            scoreText.text = "";
            gameOver();
        }
    }
}


