using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapeChanger : MonoBehaviour
{
    // int round = 0;
    public GameObject triangle;
    public GameObject triangleBottomWall;
    public GameObject square;
    public GameObject squareBottomWall;
    public GameObject pentagon;
    public GameObject pentagonBottonWall;
    public GameObject bottomWallToShow;
    // public ballMove ballSpeed;
    public float ballSpeedInit;
    // private int rotation;
    //public GameObject hexagon;
    //public GameObject octagon;
    public float countdown = 5f;
    // int rounds = 0;
    // float initialCountdown = 17f;

    // Start is called before the first frame update
    void Start()
    {
        // rounds = 1;
        square.SetActive(true);
        // round += 1;
        // ballSpeedInit = ballSpeed.speed;
        // rotation = 0;
    }

    // Update is called once per frame
    void Update()
    {}

    public void Square()
    {
        bottomWallToShow = squareBottomWall;
        // ballSpeed.speed = 0;
        pentagon.SetActive(false);
        square.SetActive(true);
        // round = 1;
        // ballSpeed.speed = ballSpeedInit + 20;
        // ballSpeedInit = ballSpeed.speed;
    }

    public void Triangle()
    {
        bottomWallToShow = triangleBottomWall;
        // ballSpeed.speed = 0;
        square.SetActive(false);
        triangle.SetActive(true);
        // round += 1;
        //ballSpeed.speed = ballSpeedInit + 20;
        //ballSpeedInit = ballSpeed.speed;
    }

    public void Pentagon()
    {
        bottomWallToShow = pentagonBottonWall;
        // ballSpeed.speed = 0;
        triangle.SetActive(false);
        pentagon.SetActive(true);
        // round += 1;
        //ballSpeed.speed = ballSpeedInit + 20;
        //ballSpeedInit = ballSpeed.speed;
    }
}
