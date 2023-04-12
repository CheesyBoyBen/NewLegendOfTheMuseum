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
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = player.GetComponent<PlayerMovement>();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(arrowSpeed * Vector3.left, ForceMode.Impulse);
    }

    void Update()
    {

       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerMovement.TakeDamage(damage, this.gameObject);
            Destroy(this.gameObject);
        }
    }
}
