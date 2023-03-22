using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleWall : MonoBehaviour
{
    public GameObject player;
    public float distance;
    public MeshRenderer wallRenderer;
    public Material wallMat;
    public Material invisWallMat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= distance)
        {
            wallRenderer.material = invisWallMat;
        }
        else
        {
            wallRenderer.material = wallMat;

        }
    }
}
