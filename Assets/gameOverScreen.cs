using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    public void SetUp(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS";
    }

    public void restartButton(int score)
    {
        SceneManager.LoadScene("baseScene");
    }

}
