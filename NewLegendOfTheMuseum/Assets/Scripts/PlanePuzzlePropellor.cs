using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePuzzlePropellor : MonoBehaviour
{
    public GameObject Propellor;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Propellor")
        {

            Propellor.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
