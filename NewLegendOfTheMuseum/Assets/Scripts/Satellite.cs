using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satellite : MonoBehaviour
{
    public GameObject BuiltPart;
    public PickUpObject puo;
    public GameObject transparentObject;

    public string tag;

    public LaserCounter laserCounter;



    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == tag)
        {
            puo.canpickup = true;
            BuiltPart.SetActive(true);
            Destroy(transparentObject.gameObject);
            laserCounter.Add();
            Destroy(this.gameObject);

        }
    }

    void Update()
    {

    }
}
