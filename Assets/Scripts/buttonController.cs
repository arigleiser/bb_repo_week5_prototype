using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class buttonController : MonoBehaviour
{
    public Rigidbody2D rb;
    //public void Restart()
    //{
    //    Time.timeScale = 1;
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //}

    public void Restart()
    {
        PlayerPrefs.DeleteAll();
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void Quit()
    {
        Application.Quit();
    }
}
