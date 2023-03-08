using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int damage;
    public float maxHealth;
    public float currentHealth;

    public Image healthBar;

    public LayerMask playerLayers;

    public float knockbackForce;
    public float knockbackTime;
    Vector3 knockbackVelocity;

    public float pushForce;
    public float pushTime;
    Vector3 pushVelocity;

    CharacterController ch;

    Rigidbody rb;
    Vector3 dir;

    public PlayerMovement playerMovement;

    public GameObject player;
    public float speed;

    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        ch = GetComponent<CharacterController>();

        currentHealth = maxHealth;
        rb = GetComponent<Rigidbody>();


    }

    private void Update()
    {
        if (pushTime >= 0)
        {
            pushTime -= Time.deltaTime;
        }
        else if (knockbackTime <= 0)
        {
            distance = Vector3.Distance(transform.position, player.transform.position);
            Vector3 direction = player.transform.position - transform.position;

            transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);


            if (Vector3.Distance(transform.position, player.transform.position) < 1f)
            {
                if (playerMovement.knockbackTime <= 0)
                {
                    playerMovement.TakeDamage(damage, this.gameObject);
                }
            }
        }
        else
        {
            knockbackTime -= Time.deltaTime;

            ch.Move(knockbackVelocity * knockbackForce);

            if (knockbackForce < 0) { knockbackForce = 0; }
            else { knockbackForce -= Time.deltaTime / 10; }
        }

    }


    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.fillAmount = currentHealth / maxHealth;


        if (currentHealth <= 0)
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

        knockbackForce = 0.03f;
        knockbackVelocity = (transform.position - player.transform.position);
        knockbackVelocity.y = 0f;

        knockbackTime = 1f;
    }

    public void Push(GameObject player)
    {

        pushForce = 0.03f;
        pushVelocity = (transform.position - player.transform.position);
        pushVelocity.y = 0f;

        ch.Move(pushVelocity * pushForce);

        pushTime = 1f;
    }


}
