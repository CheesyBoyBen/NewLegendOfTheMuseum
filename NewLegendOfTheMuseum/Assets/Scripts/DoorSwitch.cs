using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorSwitch : MonoBehaviour
{
    public int DCounter;

    

    // Start is called before the first frame update
    void Start()
    {
        DCounter = 0;
        
    }

    private void Update()
    {
        if (DCounter == 3)
            this.gameObject.SetActive(true);
    }

    // Update is called once per frame
    public void Add()
    {
        DCounter++; 
    }

    public void Subtract()
    {
        DCounter--;

    }


}
