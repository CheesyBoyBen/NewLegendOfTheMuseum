using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactCheck : MonoBehaviour
{
    // Start is called before the first frame update

    public PlayerMovement pm;

    public GameObject portal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pm.artifactCheck) { portal.SetActive(true); }

    }
}
