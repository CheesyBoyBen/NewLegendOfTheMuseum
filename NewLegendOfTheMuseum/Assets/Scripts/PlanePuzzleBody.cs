using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePuzzleBody : MonoBehaviour
{
    public PickUpObject puo;
    public GameObject Body;
    public GameObject tWings;

    public bounce b;
    private bool once = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Body")
        {
            if (!once)
            {
                puo.canpickup = true;
                Body.SetActive(true);
                b.Add();
                Destroy(tWings.gameObject);
                Destroy(this.gameObject);
                once = true;

            }
        }
    }
}
