using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserCounter : MonoBehaviour
{
    public int counter = 0;

    public GameObject laser;

    // Update is called once per frame
    void Update()
    {
        if (counter == 4)
        {
            laser.SetActive(true);
        }
    }

    public void Add()
    {
        counter++;
    }
}
