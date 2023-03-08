using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePuzzel : MonoBehaviour
{
    public GameObject Wings;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Wing")
        {
 
            Wings.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
