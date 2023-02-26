using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleScript : MonoBehaviour
{
    private float xMin;
    private float xMax;
    private float yMin;
    private float yMax;
    public cameraShake cs;
    private Vector3 startPos;

    void Start()
    {
            xMin = -2.7f;
            xMax = 2.7f;
            yMin = -2.7f;
            yMax = 2.5f;
        startPos = transform.position; 
    }

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.transform.position.z - transform.position.z;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        float x = Mathf.Clamp(worldPosition.x, xMin, xMax);
        float y = Mathf.Clamp(worldPosition.y, yMin, yMax);
        transform.position = new Vector3(x, y, transform.position.z);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            cs.ShakeCamera();
        }
    }
}

