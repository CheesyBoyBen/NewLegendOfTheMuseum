using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePuzzel : MonoBehaviour
{
    public GameObject Wings;
    public PickUpObject puo;
    public GameObject tWings;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Wing")
        {
            puo.canpickup = true;
            Wings.SetActive(true);
            Destroy(tWings.gameObject);
            Destroy(this.gameObject);
        }
    }
}
