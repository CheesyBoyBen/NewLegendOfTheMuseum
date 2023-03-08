using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePuzzleBody : MonoBehaviour
{
    public GameObject Body;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Body")
        {

            Body.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
