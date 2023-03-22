using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setPortalActive : MonoBehaviour
{

    public GameObject p;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            p.gameObject.SetActive(true);
        }
    }
}
