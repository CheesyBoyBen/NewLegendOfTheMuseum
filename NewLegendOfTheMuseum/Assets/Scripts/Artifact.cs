using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artifact : MonoBehaviour
{

    public GameObject portal;

    public PlayerMovement pm;

    static bool collected = false;


    private void Start()
    {
        
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision)
    {
            portal.SetActive(true);
            collected = true;
            pm.ArtifactAdd();
            Destroy(this.gameObject);

        
    }

    private void Update()
    {
        if (collected)
        {
            portal.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
