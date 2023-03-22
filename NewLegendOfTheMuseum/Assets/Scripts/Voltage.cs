using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Voltage : MonoBehaviour
{
    [Header("Text File")]
    public TMP_Text Text;

    private int counter;
    private bool canAdd;

    public DoorSwitch ds;

    private bool oneTime = false;

    public GameObject elevator;

    // Start is called before the first frame update
    void Start()
    {
        canAdd = false;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = counter.ToString();
        if (Input.GetKeyDown(KeyCode.Z) && canAdd == true)
        {
            counter++;
        }

        if (counter > 5)
            counter = 0;
        if (counter == 3 && !oneTime)
        {
            ds.Add();
            oneTime = true; 
        }

        if(ds.DCounter == 3)
            elevator.gameObject.SetActive(true);

    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            canAdd = true;  

        }
    }

    private void OnTriggerExit(Collider other)
    {
        canAdd = false;
    }
}
