using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int maxHealth;
    private int currentHealth;

    public float moveSpeed;
    private float gravity = -9.81f;
    private float velocity;
    public float gravityMultiplier = 3.0f;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    public int attackDamage = 40;
    public float attackRate = 2f;
    float nextAttackTime = 0f;

    CharacterController ch;

    public float knockbackForce;
    public float knockbackTime;

    Rigidbody rb;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        ch = GetComponent<CharacterController>();
        currentHealth = maxHealth;

        rb = GetComponent<Rigidbody>();



    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        float z = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;

        if (knockbackTime <= 0)
        {
            ch.enabled = true;


            if (ch.isGrounded)
            {
                velocity = -1.0f;
            }
            else
            {
                velocity += gravity * gravityMultiplier * Time.deltaTime;
            }


            ch.Move(new Vector3(x, velocity, z));

            if (Time.time >= nextAttackTime)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Attack();
                    nextAttackTime = Time.time + 1f / attackRate;
                }
            }
        }
        else
        {
            knockbackTime -= Time.deltaTime;
        }

    }

    void Attack()
    {
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);
    
        foreach(Collider enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
            enemy.GetComponent<Enemy>().Knockback(this.gameObject);
        }
    
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null) return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

    public void TakeDamage(int damage, GameObject enemy)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Debug.Log("Player died!");
        }

        Knockback(enemy);

    }

    public void Knockback(GameObject enemy)
    {
        ch.enabled = false;

        dir = (transform.position - enemy.transform.position);
        dir.y = 2.0f;

        rb.AddForce(dir * knockbackForce);
        knockbackTime = 0.5f;
        Debug.Log("Player knockback");

      

    }

}
