using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleScript : MonoBehaviour
{
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position; 
    }

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition; 
        mousePosition.z = Camera.main.transform.position.z - transform.position.z; 
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition); 

        float x = Mathf.Clamp(worldPosition.x, startPos.x + xMin, startPos.x + xMax);
        float y = Mathf.Clamp(worldPosition.y, startPos.y + yMin, startPos.y + yMax);

        transform.position = new Vector3(x, y, transform.position.z);
    }
}

