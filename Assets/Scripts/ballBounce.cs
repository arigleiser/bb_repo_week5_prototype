using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBounce : MonoBehaviour
{
    //public AudioSource bounceSound;
    //Rigidbody2D rb;
    //// public cameraShake cs;
    //Vector3 lastVelocity;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    lastVelocity = rb.velocity;
    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    bounceSound.Play();
    //    // cs.ShakeCamera();
    //    var speed = lastVelocity.magnitude;
    //    var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
    //    rb.velocity = direction * Mathf.Max(speed, 0f);
    //}
}