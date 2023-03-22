using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InteractableObject : MonoBehaviour
{
    public GameObject player;
    public GameObject playerCamera;
    public Image image;
    public float minDist;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerCamera.transform);


        if (Vector3.Distance(transform.position, player.transform.position) <= minDist)
        {
            image.enabled = true;
        }
        else 
        {
            image.enabled = false;
        }
    }
}
