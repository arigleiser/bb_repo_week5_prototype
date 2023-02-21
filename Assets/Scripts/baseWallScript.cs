using System.Collections;
using UnityEngine;

public class baseWallScript : MonoBehaviour
{
    public GameObject objectToShow;
    public AudioSource sound;

    //public shapeChanger shapeBottomWall;
    //int round;
    //public shapeChanger shape;

   
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(show());
            sound.Play();
        }
    }

    private IEnumerator show()
    {
        objectToShow.SetActive(true);
        yield return new WaitForSeconds(.16f);
        objectToShow.SetActive(false);

        //shape.bottomWallToShow.SetActive(true);
        //shape.bottomWallToShow.SetActive(false);
    }
}
