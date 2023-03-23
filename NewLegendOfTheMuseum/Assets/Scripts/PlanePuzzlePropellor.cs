using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePuzzlePropellor : MonoBehaviour
{
    public PickUpObject puo;
    public GameObject Propellor;
    public GameObject tWings;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Propellor")
        {
            puo.canpickup = true;
            Propellor.SetActive(true);
            Destroy(tWings.gameObject);
            Destroy(this.gameObject);
        }
    }
}
