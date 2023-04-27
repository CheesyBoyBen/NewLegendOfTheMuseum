using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{

    public GameObject image;
    // Start is called before the first frame update
    void Start()
    {

        image.SetActive(true);
        StartCoroutine(scene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator scene()
    {

        for (int i = 100; i >= 0; i--)
        {
            yield return new WaitForSeconds(0.1f);

            if (Input.GetKey(KeyCode.Space))
            {
                break;
            }
        }

        image.SetActive(false);

        for (int i = 100; i >= 0; i--)
        {
            yield return new WaitForSeconds(0.1f);

            if (Input.GetKey(KeyCode.Space))
            {
                break;
            }
        }


        SceneManager.LoadScene("Menu");
    }
}
