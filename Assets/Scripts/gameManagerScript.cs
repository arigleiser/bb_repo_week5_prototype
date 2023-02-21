using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class gameManagerScript : MonoBehaviour
{
    public GameObject restartButton;
    public GameObject quitButton;
    // public GameObject ball;
    public ballScript bs;
    //public loseIfTouchFloor floor;

    public TMP_Text disvar;

    // Update is called once per frame
    void Update()
    {
        //if (bs.isAlive == false)
        //{
        //    gameOver();
        //}
        // Debug.Log(playerScript.upspeed);
        //if (ball.transform.position.y <= -3.4)
        //{
        //    gameOver();
        //}
        //else if (ball.transform.position.y >= 4)
        //{
        //    gameOver();
        //}
    }

    public void gameOver()
    {
        disvar.text = "Game Over!";
        restartButton.SetActive(true);
        //quitButton.SetActive(true);
        //Time.timeScale = 1;
    }

}