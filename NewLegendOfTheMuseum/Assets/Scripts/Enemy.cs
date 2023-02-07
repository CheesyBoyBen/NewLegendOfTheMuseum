using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage;
    public int maxHealth = 100;
    int currentHealth;

    public float knockbackForce;
    public float knockbackTime;

    Rigidbody rb;
    Vector3 dir;

    public PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        rb = GetComponent<Rigidbody>();


    }

    private void Update()
    {
        if (knockbackTime <= 0)
        {

        }
        else
        {
            knockbackTime -= Time.deltaTime;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerMovement.TakeDamage(damage, this.gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(this.gameObject);
    }

    public void Knockback(GameObject player)
    {
        dir = (transform.position - player.transform.position);
        dir.y = 2.0f;

        rb.AddForce(dir * knockbackForce);

        knockbackTime = 2.0f;
    }


}
