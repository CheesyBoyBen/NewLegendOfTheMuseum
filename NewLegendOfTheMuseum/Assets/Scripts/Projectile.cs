using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject player;
    public PlayerMovement playerMovement;

    private Vector3 normalizeDirection;

    public float speed = 5f;
    public float existTime = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerMovement = player.GetComponent<PlayerMovement>();

        normalizeDirection = (player.transform.position - transform.position);
        normalizeDirection.y = 0f;
        normalizeDirection = normalizeDirection.normalized;

        transform.LookAt(player.transform);
    }

    // Update is called once per frame
    void Update()
    {
        



        if (existTime >= 0)
        {
            transform.position += normalizeDirection * speed * Time.deltaTime;
        }
        else
        {
            Destroy(this.gameObject);
        }

        existTime -= Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            playerMovement.TakeDamage(20, this.gameObject);
        }
    }
}
