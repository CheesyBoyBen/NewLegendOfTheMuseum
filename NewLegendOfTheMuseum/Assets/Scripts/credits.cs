using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(scene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator scene()
    {
        
        yield return new WaitForSeconds(10f);


        SceneManager.LoadScene("Menu");
    }
}
