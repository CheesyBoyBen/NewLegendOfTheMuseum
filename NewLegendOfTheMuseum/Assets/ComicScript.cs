using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComicScript : MonoBehaviour
{

    private int counter;

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panelfinal;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            counter++;
        }

        if (counter == 1) 
        {
            panel1.SetActive(false);
            panel2.SetActive(true);
        }

        if (counter == 2)
        {
            panel2.SetActive(false);
            panel3.SetActive(true);
        }
        if (counter == 3)
        {
            panel3.SetActive(false);
            panel4.SetActive(true);
        }
        if (counter == 4)
        {
            panel4.SetActive(false);
            panelfinal.SetActive(true);
        }
        if (counter == 5)
        {
            SceneManager.LoadScene("HubArea");
        }
    }


}
