using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushableScript : MonoBehaviour
{
    private float pushForce;
    public float pushForceMax;
    public float pushTime;
    Vector3 pushVelocity;

    CharacterController ch;

    // Start is called before the first frame update
    void Start()
    {
        ch = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pushTime >= 0)
        {
            pushTime -= Time.deltaTime;

            ch.Move(pushVelocity * pushForce);

            if (pushForce < 0) { pushForce = 0; }
            else { pushForce -= Time.deltaTime / 10; }
        }
    }

    public void Push(GameObject player)
    {
       
        pushForce = pushForceMax;
        pushVelocity = (transform.position - player.transform.position);
        pushVelocity.y = 0f;


        pushTime = 1f;
    }
}
