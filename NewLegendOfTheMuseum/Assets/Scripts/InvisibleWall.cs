using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleWall : MonoBehaviour
{
    public float Distance;
    public GameObject player;
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
        if (Vector3.Distance(transform.position, player.transform.position) <= Distance)
        {
            wallRenderer.material = invisWallMat;
        }
        else
        {
            wallRenderer.material = wallMat;

        }
    }
}
