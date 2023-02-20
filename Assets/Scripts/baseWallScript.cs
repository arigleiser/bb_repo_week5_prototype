using System.Collections;
using UnityEngine;

public class baseWallScript : MonoBehaviour
{
    public GameObject objectToShow;
    public AudioSource sound;

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
        yield return new WaitForSeconds(.1f);
        objectToShow.SetActive(false);
    }
}
