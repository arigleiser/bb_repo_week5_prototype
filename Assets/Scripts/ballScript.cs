using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public bool isAlive;

    void Start()
    {
        tempcountdown = countdown;
        speed = initialSpeed;
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(60 * Time.deltaTime * speed, 60 * Time.deltaTime * speed));
        isAlive = true;
    }

    void Update()
    {
        if (gameObject.transform.position.y <= -3.4)
        {
            isAlive = false;
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

    }
}


