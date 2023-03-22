using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorsePuzzle : MonoBehaviour
{
    public GameObject dot;
    public GameObject dash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Vector3.Distance(dot.transform.position, dash.transform.position) <= 2f)
            {
                Debug.Log("test");
            }
        }
    }
}
