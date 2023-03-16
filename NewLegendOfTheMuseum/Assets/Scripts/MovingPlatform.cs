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

    void Start()
    {
        moveTime = 0.01f;
        move = true;
    }

    void Update()
    {
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
    }
}
