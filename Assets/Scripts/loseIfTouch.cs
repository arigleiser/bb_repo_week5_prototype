using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loseIfTouch : MonoBehaviour
{
    public gameManagerScript gameMan;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameMan.gameOver();
    }
}
