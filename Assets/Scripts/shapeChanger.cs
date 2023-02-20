using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapeChanger : MonoBehaviour
{
    int round = 0;
    public GameObject triangle;
    public GameObject square;
    public GameObject pentagon;
    //public GameObject hexagon;
    //public GameObject octagon;
    public float countdown = 10f;
    int pastShape;
    // int rounds = 0;
    // float initialCountdown = 17f;

    // Start is called before the first frame update
    void Start()
    {
        // rounds = 1;
        square.SetActive(true);
        pastShape = 2;
        round += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown > 0)
        {
            countdown -= Time.deltaTime;
       
        }

        else if (countdown <= 0)
        {
            countdown = 3f;
            if (round % 3 == 0)
            {
                pentagon.SetActive(false);
                square.SetActive(true);
                round += 1;
            }
            else if (round % 2 == 0)
            {
                triangle.SetActive(false);
                pentagon.SetActive(true);
                round += 1;
            }
            else
            {
                square.SetActive(false);
                triangle.SetActive(true);
                round += 1;
            }
        }
    }
}
