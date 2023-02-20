using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class gameManagerScript : MonoBehaviour
{
    public GameObject restartButton;
    public GameObject quitButton;
    public GameObject ball;
    //public loseIfTouchFloor floor;

    public TMP_Text disvar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(playerScript.upspeed);
        if (ball.transform.position.y <= -3.4)
        {
            gameOver();
        }
    }

    public void gameOver()
    {
        disvar.text = "Game Over!";
        restartButton.SetActive(true);
        quitButton.SetActive(true);
        //Time.timeScale = 1;
    }

}