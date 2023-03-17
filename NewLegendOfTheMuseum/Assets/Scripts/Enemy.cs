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

    public Image image;
    public Sprite pow;
    public Sprite bam;
    public Sprite whack;

    public LayerMask playerLayers;

    public float knockbackForce;
    public float knockbackTime;
    Vector3 knockbackVelocity;

    public float pushForce;
    public float pushTime;
    Vector3 pushVelocity;

    CharacterController ch;

    public PlayerMovement playerMovement;

    public GameObject player;
    public float speed;

    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        ch = GetComponent<CharacterController>();

        currentHealth = maxHealth;


    }

    private void Update()
    {
        if (pushTime >= 0)
        {
            pushTime -= Time.deltaTime;

            ch.Move(pushVelocity * pushForce);

            if (pushForce < 0) { pushForce = 0; }
            else { pushForce -= Time.deltaTime / 10; }
        }
        else if (knockbackTime <= 0)
        {
            image.enabled = false;
            distance = Vector3.Distance(transform.position, player.transform.position);
            Vector3 direction = (player.transform.position - transform.position) * speed * Time.deltaTime;

            ch.Move(new Vector3(direction.x, 0, direction.z));


            if (Vector3.Distance(transform.position, player.transform.position) < 2f)
            {
                if (playerMovement.knockbackTime <= 0)
                {
                    playerMovement.TakeDamage(damage, this.gameObject);
                }
            }
        }
        else
        {
            image.enabled = true;

            knockbackTime -= Time.deltaTime;

            ch.Move(knockbackVelocity * knockbackForce);

            if (knockbackForce < 0) { knockbackForce = 0; }
            else { knockbackForce -= Time.deltaTime / 10; }
        }

    }


    public void TakeDamage(int damage)
    {
        float index = Random.Range(0, 3);
        switch (index)
        {
            case 0:
                image.sprite = pow;
                break;
            case 1:

                image.sprite = bam;
                break;
            case 2:
                image.sprite = whack;
                break;
        }


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

        pushForce = 0.05f;
        pushVelocity = (transform.position - player.transform.position);
        pushVelocity.y = 0f;


        pushTime = 1f;
    }


}
