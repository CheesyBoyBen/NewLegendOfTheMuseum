using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 1.19f;
    public Vector3 pointA;
    public Vector3 pointB;

    void Start()
    {
        //pointA = new Vector3(0, 0, 0);
        //pointB = new Vector3(5, 0, 0);
    }

    void Update()
    {
        //PingPong between 0 and 1
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}
