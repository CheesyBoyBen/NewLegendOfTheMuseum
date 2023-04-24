using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artifact : MonoBehaviour
{

    public GameObject portal;


    private void Start()
    {
        
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision)
    {
            portal.SetActive(true);
            Destroy(this.gameObject);

        
    }
}
