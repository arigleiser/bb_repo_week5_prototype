using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakeScript : MonoBehaviour
{
    public cameraShake cs;

 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "obstacle")
        {
            cs.ShakeCamera();
        }
      
    }
}
