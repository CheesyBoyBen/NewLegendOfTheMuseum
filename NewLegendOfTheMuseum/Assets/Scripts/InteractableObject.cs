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

    private float time;
    public float speed = 5;


    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerCamera.transform);


        if ((Vector3.Distance(transform.position, player.transform.position) <= minDist) && (playerCamera.transform.parent != null))
        {
            image.enabled = true;
            time += Time.deltaTime * speed;
            if (time > 1f) { time = 1f; }
            Apear();
        }
        else 
        {
            image.enabled = false;
            time = 0;
        }
    }

    void Apear()
    {
        image.enabled = true;

        image.transform.localScale = Vector3.Lerp(new Vector3(0, 0, 0), new Vector3(0.01f, 0.01f, 0.01f), time); ;

    }

    void Disapear()
    {

    }
}
