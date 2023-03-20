using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;
    public Vector3 pointA;
    public Vector3 pointB;

    private bool move;
    private float moveTime;

    private Vector3 posChange;
    private Vector3 lastPos;
    private Vector3 newPos;

    private GameObject player;
    private GameObject enemy;

    void Start()
    {
        moveTime = 0.01f;
        move = true;
    }

    void Update()
    {
        lastPos = transform.position;

        if (move == true)
        {
            float time = Mathf.PingPong(Time.time * speed, 1);
            transform.position = Vector3.Lerp(pointA, pointB, time);

            moveTime -= Time.deltaTime;
            if (moveTime <= 0)
            {
                move = false;
                moveTime = 1.0f;
            }
        }
        else if (move == false)
        {
            moveTime -= Time.deltaTime;
            if (moveTime <= 0)
            {
                move = true;
                moveTime = 0.01f;
            }
        }

        newPos = transform.position;
        posChange = newPos - lastPos;

        if (player != null)
        {
            player.GetComponent<PlayerMovement>().OnPlatform(posChange);
        }

        if (enemy != null)
        {
            enemy.GetComponent<Enemy>().OnPlatform(posChange);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player = other.gameObject;
        }

        if (other.tag == "Enemy")
        {
            enemy = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            player = null;
        }

        if (other.tag == "Enemy")
        {
            enemy = null;
        }
    }

}
