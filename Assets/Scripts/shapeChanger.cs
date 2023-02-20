using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapeChanger : MonoBehaviour
{
    int round = 0;
    public GameObject triangle;
    public GameObject triangleBottomWall;
    public GameObject square;
    public GameObject squareBottomWall;
    public GameObject pentagon;
    public GameObject pentagonBottonWall;
    public GameObject bottomWallToShow;
    public ballMove ballSpeed;
    public float ballSpeedInit;
    // public Camera mainCam;
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
        round += 1;
        ballSpeedInit = ballSpeed.speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown > 0 && countdown != 2)
        {
            countdown -= Time.deltaTime;
       
        }

        else if (countdown <= 0)
        {
            countdown = Random.Range(2, 10);
            if (round % 3 == 0)
            {
                bottomWallToShow = squareBottomWall;
                ballSpeed.speed = 0;
                pentagon.SetActive(false);
                square.SetActive(true);
                round = 1;
                ballSpeed.speed = ballSpeedInit + 20;
                ballSpeedInit = ballSpeed.speed;
            }
            else if (round % 2 == 0)
            {
                bottomWallToShow = pentagonBottonWall;
                ballSpeed.speed = 0;
                triangle.SetActive(false);
                pentagon.SetActive(true);
                round += 1;
                ballSpeed.speed = ballSpeedInit + 20;
                ballSpeedInit = ballSpeed.speed;
            }
            else
            {
                bottomWallToShow = triangleBottomWall;
                ballSpeed.speed = 0;
                square.SetActive(false);
                triangle.SetActive(true);
                round += 1;
                ballSpeed.speed = ballSpeedInit + 20;
                ballSpeedInit = ballSpeed.speed;
            }
        }
    }
}
