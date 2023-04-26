using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserCounter : MonoBehaviour
{
    public int counter = 0;

    public GameObject laser;

    public GameObject sun;


    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 4)
        {
            laser.SetActive(true);
            sun.SetActive(true);
            
        }
    }

    public void Add()
    {
        counter++;
    }
}
