using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMover : MonoBehaviour
{
    public Vector3 targetPos;
    public Vector3 targetRot;
    public GameObject cam;
    private camera camScript;
    private bool inRadius;


    // Start is called before the first frame update
    void Start()
    {
        camScript = cam.GetComponent<camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((inRadius) && (Input.GetKeyDown(KeyCode.E)))
        {
            playerEnter();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inRadius = true;


        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inRadius = false;
            playerExit();
        }
    }

    void playerEnter()
    {
        camScript.MoveToPos(targetPos, targetRot);
    }

    void playerExit()
    {
        camScript.MoveToDefault();
    }
}
