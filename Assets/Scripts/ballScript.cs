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
    public int score;
    public TMP_Text scoreText;
    public Rigidbody2D rb;
    Vector3 lastVelocity;
    // public bool isAlive;
    public GameObject restartButton;
    public GameObject quitButton;
    // public GameObject ball;
    // public ballScript bs;
    //public loseIfTouchFloor floor;

    public TMP_Text disvar;

    void Start()
    {
        // disvar.text = "HELLOOO";
        tempcountdown = countdown;
        speed = initialSpeed;
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(60 * Time.deltaTime * speed, 60 * Time.deltaTime * speed));
        // isAlive = true;
        score = 0;
        scoreText.text = "Score: " + score.ToString();
    }

    void Update()
    {
        if (gameObject.transform.position.y <= -3.4)
        {
            disvar.text = "Game Over!";
            restartButton.SetActive(true);
            quitButton.SetActive(true);
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
            scoreText.text = "Score: " + score.ToString();
        }
    }
}


