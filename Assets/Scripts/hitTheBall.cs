using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitTheBall : MonoBehaviour
{
    int round;
    public GameObject ball;
    public shapeChanger shape;
    // Start is called before the first frame update
    void Start()
    {
        round = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ball.GetComponent<Rigidbody2D>().AddForce(new Vector3(20, 20, 0));
        if (round % 3 == 0)
        {
            //square
            round = 1;
            shape.Square();
        }
        else if (round % 2 == 0)
        {
            //pentagon
            round += 1;
            shape.Pentagon();
        }
        else
        {
            //triangle
            round += 1;
            shape.Triangle();
        }
    }
}
