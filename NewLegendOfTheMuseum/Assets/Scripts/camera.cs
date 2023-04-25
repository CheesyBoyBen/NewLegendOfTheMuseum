using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private Vector3 defaultPos;
    private Vector3 defaultRot;
    public GameObject player;

    public bool tempNOTOUCH;


    // Start is called before the first frame update
    void Start()
    {
        defaultPos = transform.localPosition;
        defaultRot = transform.localEulerAngles;
        tempNOTOUCH = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToPos(Vector3 pos, Vector3 rot)
    {

            transform.parent = null;
            transform.localPosition = pos;
            transform.localEulerAngles = rot;
        
    }

    public void MoveToDefault()
    {
        
        transform.parent = player.transform;
        transform.localPosition = defaultPos;
        transform.localEulerAngles = defaultRot;
        
    }
}
