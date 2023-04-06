using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killbox : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform respawnPoint;

    public GameObject player;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            print("w");
            collision.transform.position = respawnPoint.transform.position;
        }
    }
}
