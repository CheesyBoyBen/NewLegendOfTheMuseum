using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour, Interactable
{

    [Header("Dash")]
    public float dashSpeed;
    public float dashTime;
    public KeyCode dashKey = KeyCode.E;

    [Header("Push")]
    public KeyCode pushKey = KeyCode.Q;
    public float pushRange = 10f;
    public float pushCooldown = 3f;



    [Header("Health")]
    public float maxHealth;
    public float currentHealth;
    public Image healthBar;





    [Header("Move")]
    public float moveSpeed;
    private float gravity = -9.81f;
    private float velocity;
    public float gravityMultiplier = 3.0f;
    [Header("Attack")]
    public Transform attackPoint;
    public Transform interactPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

   

    public LayerMask NPCLayers;

    public int attackDamage = 40;
    public float attackRate = 2f;
    float nextAttackTime = 0f;
    [Header("Interact")]
    public float interactRange = 3f;

     CharacterController ch;
    [Header("Knockback")]
    public float knockbackForce;
    public float knockbackTime;

    Rigidbody rb;
    Vector3 knockbackVelocity;

    [Header("Audio")]
    public AudioClip attackAudio;
    public AudioManager audioManager;

    // Start is called before the first frame update
    void Start()
    {
        ch = GetComponent<CharacterController>();
        currentHealth = maxHealth;

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void HandleUpdate()
    {

        float x = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        float z = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;

        if (knockbackTime <= 0)
        {


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

            ch.Move(knockbackVelocity * knockbackForce);

            if (knockbackForce < 0) { knockbackForce = 0; knockbackTime = 0; }
            else { knockbackForce -= Time.deltaTime / 10; }
        }

        if (currentHealth < maxHealth)
        {
            currentHealth += Time.deltaTime;

            if (currentHealth > maxHealth) { currentHealth = maxHealth; }

            healthBar.fillAmount = currentHealth / maxHealth;

        }

        
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Interact();
        }

        if (Input.GetKeyDown(dashKey))
        {
            StartCoroutine(Dash());
        }
        if ((Input.GetKey(pushKey)) && (pushCooldown <= 0))
        {
            push();
            //pushCooldown = 3f;
        }

        pushCooldown -= Time.deltaTime;
    }

    IEnumerator Dash()
    {
        float startTime = Time.time;
        float x = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        float z = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;

        while (Time.time < startTime + dashTime)
        {
            ch.Move(new Vector3(x, velocity, z) * dashSpeed * Time.deltaTime);

            yield return null;
        }
    }
    public void push()
    {
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, pushRange, enemyLayers);

        foreach (Collider enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().Push(this.gameObject);
        }
    }
    public void Interact()
    {
        var collision = Physics.OverlapSphere(interactPoint.position, interactRange, NPCLayers);
            foreach (Collider NPC in collision)
            {
                NPC.gameObject.GetComponent<Interactable>()?.Interact();
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

        audioManager.PlayAudio(attackAudio);
    
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null) return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

    public void TakeDamage(int damage, GameObject enemy)
    {


        currentHealth -= damage;
        healthBar.fillAmount = currentHealth / maxHealth;


        if (currentHealth <= 0)
        {
            Debug.Log("Player died!");
        }

        Knockback(enemy);

    }

    public void Knockback(GameObject enemy)
    {
        Debug.Log("test");


        knockbackForce = 0.05f;
        knockbackVelocity = (transform.position - enemy.transform.position);
        knockbackVelocity.y = 0f;

        knockbackTime = 0.5f;

      

    }

}
