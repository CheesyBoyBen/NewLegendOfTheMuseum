using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour, Interactable
{
    public KeyCode powerKey = KeyCode.E;

    [Header("Dash")]
    public float dashSpeed;
    public float dashTime;
    public KeyCode dashKey = KeyCode.E;

    [Header("Push")]
    public KeyCode pushKey = KeyCode.Q;
    public float pushRange = 10f;
    private float pushCooldown = 0f;
    public float pushCooldownMax = 3f;

    public float curPower;

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
    public LayerMask pushLayers;

   

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


    Vector3 knockbackVelocity;

    [Header("Audio")]
    public AudioClip attackAudio;
    public AudioManager audioManager;

    public Animator anim;
    public GameObject mesh;

    private Rigidbody rb;




    // Start is called before the first frame update
    void Start()
    {
        ch = GetComponent<CharacterController>();
        currentHealth = maxHealth;
        curPower = 1;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void HandleUpdate()
    {
        if (!(anim.GetCurrentAnimatorStateInfo(0).IsName("spin")))
        {
            if ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.UpArrow)) || (Input.GetKey(KeyCode.LeftArrow)) || (Input.GetKey(KeyCode.DownArrow)) || (Input.GetKey(KeyCode.RightArrow)))
            {
                anim.Play("running");

            }
            else { anim.Play("idle");}
        }

        // Get the horizontal and vertical input values
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the camera forward vector
        Vector3 cameraForward = Camera.main.transform.forward;
        cameraForward.y = 0f;   // Ignore the camera's vertical rotation

        // Calculate the camera right vector
        Vector3 cameraRight = Camera.main.transform.right;

        // Calculate the movement direction based on the input values and camera vectors
        Vector3 direction = (horizontalInput * cameraRight + verticalInput * cameraForward).normalized;

        // Rotate the character towards the movement direction
        if (direction.magnitude > 0f)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }

        // Move the character in the direction of the input values
        transform.position += direction * moveSpeed * Time.deltaTime;





        // float x = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        //   float z = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;

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

          //  ch.Move(new Vector3(x, velocity, z));

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

        
        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            curPower = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            curPower = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            curPower = 3;
        }

        if (Input.GetKeyDown(powerKey))
        {
            if (curPower == 1)
            {
                StartCoroutine(Dash());
            }

            if ((curPower == 2) && (pushCooldown <= 0))
            {
                push();
                pushCooldown = pushCooldownMax;
            }

            if (curPower == 3)
            {
                stun();
            }
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

        Collider[] hitPushable = Physics.OverlapSphere(attackPoint.position, pushRange, pushLayers);

        foreach (Collider pushable in hitPushable)
        {
            pushable.GetComponent<PushableScript>().Push(this.gameObject);
        }
    }

    private void stun()
    {
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, pushRange, enemyLayers);

        foreach (Collider enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().Stun();
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
        anim.Play("spin");

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
        


        knockbackForce = 0.05f;
        knockbackVelocity = (transform.position - enemy.transform.position);
        knockbackVelocity.y = 0f;

        knockbackTime = 0.5f;

      

    }

    public void OnPlatform(Vector3 diff)
    {
        ch.Move(diff);        
    }
}
