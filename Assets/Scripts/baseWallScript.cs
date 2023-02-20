using System.Collections;
using UnityEngine;

public class baseWallScript : MonoBehaviour
{
    public GameObject objectToShow;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(show());
        }
    }

    private IEnumerator show()
    {
        objectToShow.SetActive(true);
        yield return new WaitForSeconds(.1f);
        objectToShow.SetActive(false);
    }
}
