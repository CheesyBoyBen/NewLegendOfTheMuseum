using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBehaviour : MonoBehaviour
{
    private Rigidbody rb;

    public float arrowSpeed = 50f;

    private PlayerMovement playerMovement;

    public int damage;

    private GameObject player;

    public Vector3 rotationAxis = Vector3.up;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = player.GetComponent<PlayerMovement>();
    }
    void Start()
    {
        transform.Rotate(rotationAxis, 90f);
        rb = GetComponent<Rigidbody>();
      //  rb.AddForce(arrowSpeed * Vector3.forward, ForceMode.Impulse);
    }

    void Update()
    {

       
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("hit");
            playerMovement.TakeDamage(damage, this.gameObject);
            print("hit");
            Destroy(this.gameObject);

        }
    }
}
