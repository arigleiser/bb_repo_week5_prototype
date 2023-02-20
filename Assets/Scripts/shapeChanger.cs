using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapeChanger : MonoBehaviour
{
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
            // countdown = initialCountdown - rounds;
            int shape = Random.Range(1, 3);
            if (pastShape == 1)
            {
                triangle.SetActive(false);
            }
            else if (pastShape == 2)
            {
                square.SetActive(false);
            }
            else if (pastShape == 3)
            {
                pentagon.SetActive(false);
            }
            pastShape = shape;

            if (countdown != 1)
            {
                countdown -= 1;
            }

            if (shape == 1)
            {
                triangle.SetActive(true);
            }
            else if (shape == 2)
            {
                square.SetActive(true);
            }
            else if (shape == 3)
            {
                pentagon.SetActive(true);
            }
            //else if (shape == 4)
            //{
            //    hexagon.SetActive(true);
            //}
            //else if (shape == 5)
            //{
            //    octagon.SetActive(true);
            //}
        }
    }
}
