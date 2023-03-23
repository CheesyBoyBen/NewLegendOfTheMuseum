using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePuzzleBody : MonoBehaviour
{
    public PickUpObject puo;
    public GameObject Body;
    public GameObject tWings;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Body")
        {
            puo.canpickup = true;
            Body.SetActive(true);
            Destroy(tWings.gameObject);
            Destroy(this.gameObject);
        }
    }
}
