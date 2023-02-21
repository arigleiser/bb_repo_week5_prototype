using System.Collections;
using UnityEngine;

public class baseWallScript : MonoBehaviour
{
    public GameObject objectToShow;
    public AudioSource sound;
    int count = 1;
    public GameObject ball;

    //public shapeChanger shapeBottomWall;
    //int round;
    //public shapeChanger shape;

   
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            count += 1;
            StartCoroutine(show());
            sound.Play();
        }

        if (count % 5 == 0)
        {
            count = 1;
            Instantiate(ball, new Vector3(0, 0, 0), Quaternion.identity);
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
