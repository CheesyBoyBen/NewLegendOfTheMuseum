using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class colliderScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void OncollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("h");
            SceneManager.LoadScene("Computer1");
        }
    }
}
