using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{
    public bool trigger;
    public GameObject left;
    public GameObject right;
    // Start is called before the first frame update
    void Start()
    {
        trigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger)
        {
            if (left.transform.localEulerAngles.z < 90)
            { 
                left.transform.localEulerAngles += new Vector3(0, 0, 1); 
            }
            if ((right.transform.localEulerAngles.z > 270) || (right.transform.localEulerAngles.z == 0))
            { 
                right.transform.localEulerAngles -= new Vector3(0, 0, 1); 
            }
        }
    }

    public void open()
    {
        trigger = true;
    }
}
