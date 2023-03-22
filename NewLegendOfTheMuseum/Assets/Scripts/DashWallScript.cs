using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashWallScript : MonoBehaviour
{

    public KeyCode dashKey = KeyCode.E;
    public float dashTime;
    public GameObject player;


    public BoxCollider col;


    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider>();

    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(dashKey))&& (player.GetComponent<PlayerMovement>().curPower == 1))
        {
            dash();
        }

        if (dashTime >= 0)
        {
            col.enabled = false;
        }
        else
        {
            col.enabled = true;

        }

        dashTime -= Time.deltaTime;
    }

    private void dash()
    {
        dashTime = 0.2f;
    }
}
