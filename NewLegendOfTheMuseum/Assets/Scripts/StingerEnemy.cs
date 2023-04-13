using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StingerEnemy : MonoBehaviour
{
    public int damage;
    public float maxHealth;
    public float currentHealth;

    public Image healthBar;

    public GameObject powImage;
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

    public float stunTime;
    public float stunTimeMax;

    CharacterController ch;

    public PlayerMovement playerMovement;

    public GameObject player;
    public float speed;
    public float chaseDist;

    private float distance;
    public float attackDistance;

    public Animator anim;

    [Header("mats")]
    public SkinnedMeshRenderer enemyRenderer;
    public Material enemyMat;
    public Material enemyFlashMat;

    // Start is called before the first frame update
    void Start()
    {
        ch = GetComponent<CharacterController>();

        currentHealth = maxHealth;
    }

    private void Update()
    {
        transform.LookAt(player.transform);

        if (pushTime >= 0)
        {
            if (!(anim.GetCurrentAnimatorStateInfo(0).IsName("Attack")))
            {
                anim.Play("Idle");
            }
                pushTime -= Time.deltaTime;

            ch.Move(pushVelocity * pushForce);

            if (pushForce < 0) { pushForce = 0; }
            else { pushForce -= Time.deltaTime / 10; }
        }
        else if (stunTime >= 0)
        {
            stunTime -= Time.deltaTime;
        }
        else if (knockbackTime <= 0)
        {
            image.enabled = false;

            distance = Vector3.Distance(transform.position, player.transform.position);            

            if (distance < chaseDist)
            {
                if (!(anim.GetCurrentAnimatorStateInfo(0).IsName("Attack")))
                {
                    anim.Play("Run");
                }

                Vector3 direction = (player.transform.position - transform.position) * speed * Time.deltaTime;

                ch.Move(new Vector3(direction.x, 0, direction.z));


                if (distance <= attackDistance)
                {
                    if (playerMovement.knockbackTime <= 0)
                    {
                        playerMovement.TakeDamage(damage, this.gameObject);
                        anim.Play("Attack");
                    }
                }
            }
            else
            {
                if (!(anim.GetCurrentAnimatorStateInfo(0).IsName("Attack")))
                {
                    anim.Play("Idle");
                }
            }
        }
        else
        {
            if (!(anim.GetCurrentAnimatorStateInfo(0).IsName("Attack")))
            {
                anim.Play("Idle");
            }

            image.enabled = true;

            knockbackTime -= Time.deltaTime;

            ch.Move(knockbackVelocity * knockbackForce);

            if (knockbackForce < 0) { knockbackForce = 0; }
            else { knockbackForce -= Time.deltaTime / 10; }
        }

        if (knockbackTime <= 0.9f)
        {
            enemyRenderer.material = enemyMat;

        }

    }


    public void TakeDamage(int damage)
    {

        enemyRenderer.material = enemyFlashMat;


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

        powImage.transform.localPosition = new Vector3(Random.Range(-200.0f, 200.0f), Random.Range(-150.0f, 50.0f), 150);

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

    public void OnPlatform(Vector3 diff)
    {
        ch.Move(diff);
    }

    public void Stun()
    {
        stunTime = stunTimeMax;
        //Debug.Log("test");
    }
}