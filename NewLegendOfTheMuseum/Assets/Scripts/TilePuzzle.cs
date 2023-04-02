using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePuzzle : MonoBehaviour
{
    public MeshRenderer tileRenderer;

    public Material tileMat;
    public Material steppedTileMat;

    private bool tile1 = false;
    private bool tile2 = false;
    private bool tile3 = false;
    private bool tile4 = false;
    private bool tile5 = false;
    private bool tile6 = false;
    private bool tile7 = false;
    private bool tile8 = false;
    private bool tile9 = false;
    private bool tile10 = false;
    private bool tile11 = false;
    private bool tile12 = false;
    private bool tile13 = false;
    private bool tile14 = false;
    private bool tile15 = false;

    public GameObject tileObject1;
    public GameObject tileObject2;
    public GameObject tileObject3;
    public GameObject tileObject4;
    public GameObject tileObject5;
    public GameObject tileObject6;
    public GameObject tileObject7;
    public GameObject tileObject8;
    public GameObject tileObject9;
    public GameObject tileObject10;
    public GameObject tileObject11;
    public GameObject tileObject12;
    public GameObject tileObject13;
    public GameObject tileObject14;
    public GameObject tileObject15;

    public GameObject arrow;

    public GameObject placement;


    private bool completeBool;

    public GameObject portal;

    public float arrowSpeed;

    // Start is called before the first frame update
    void Start()
    {
        arrowSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!completeBool)
        {
            if ((tile1 == true) && (tile2 == true) && (tile3 == true) && (tile4 == true) && (tile5 == true) && (tile6 == true) && (tile7 == true) && (tile8 == true) && (tile9 == true) && (tile10 == true) && (tile11 == true) && (tile12 == true) && (tile13 == true) && (tile14 == true) && (tile15 == true))
            {
                puzzleComeplete();
            }
        }
    }

    public void TilePressed(GameObject tile)
    {
        if (tile == tileObject1) 
        {
            if (tile1 == false)
            {
                tile1 = true;
                tileRenderer = tileObject1.GetComponent<MeshRenderer>();
                tileRenderer.material = steppedTileMat;

            }
            else
            {
                reset();
            }

        }

        if (tile == tileObject2)
        {
            if (tile2 == false)
            {
                tile2 = true;
                tileRenderer = tileObject2.GetComponent<MeshRenderer>();
                tileRenderer.material = steppedTileMat;
            }
            else
            {
                reset();
            }

        }

        if (tile == tileObject3)
        {
            if (tile3 == false)
            {
                tile3 = true;
                tileRenderer = tileObject3.GetComponent<MeshRenderer>();
                tileRenderer.material = steppedTileMat;
            }
            else
            {
                reset();
            }

        }

        if (tile == tileObject4)
        {
            if (tile4 == false)
            {
                tile4 = true;
                tileRenderer = tileObject4.GetComponent<MeshRenderer>();
                tileRenderer.material = steppedTileMat;
            }
            else
            {
                reset();
            }

        }

        if (tile == tileObject5)
        {
            if (tile5 == false)
            {
                tile5 = true;
                tileRenderer = tileObject5.GetComponent<MeshRenderer>();
                tileRenderer.material = steppedTileMat;
            }
            else
            {
                reset();
            }

        }

        if (tile == tileObject6)
        {
            if (tile6 == false)
            {
                tile6 = true;
                tileRenderer = tileObject6.GetComponent<MeshRenderer>();
                tileRenderer.material = steppedTileMat;
            }
            else
            {
                reset();
            }

        }

        if (tile == tileObject7)
        {
            if (tile7 == false)
            {
                tile7 = true;
                tileRenderer = tileObject7.GetComponent<MeshRenderer>();
                tileRenderer.material = steppedTileMat;
            }
            else
            {
                reset();
            }

        }

        if (tile == tileObject8)
        {
            if (tile8 == false)
            {
                tile8 = true;
                tileRenderer = tileObject8.GetComponent<MeshRenderer>();
                tileRenderer.material = steppedTileMat;
            }
            else
            {
                reset();
            }

        }

        if (tile == tileObject9)
        {
            if (tile9 == false)
            {
                tile9 = true;
                tileRenderer = tileObject9.GetComponent<MeshRenderer>();
                tileRenderer.material = steppedTileMat;
            }
            else
            {
                reset();
            }

        }

        if (tile == tileObject10)
        {
            if (tile10 == false)
            {
                tile10 = true;
                tileRenderer = tileObject10.GetComponent<MeshRenderer>();
                tileRenderer.material = steppedTileMat;
            }
            else
            {
                reset();
            }

        }

        if (tile == tileObject11)
        {
            if (tile11 == false)
            {
                tile11 = true;
                tileRenderer = tileObject11.GetComponent<MeshRenderer>();
                tileRenderer.material = steppedTileMat;
            }
            else
            {
                reset();
            }

        }

        if (tile == tileObject12)
        {
            if (tile12 == false)
            {
                tile12 = true;
                tileRenderer = tileObject12.GetComponent<MeshRenderer>();
                tileRenderer.material = steppedTileMat;
            }
            else
            {
                reset();
            }

        }

        if (tile == tileObject13)
        {
            if (tile13 == false)
            {
                tile13 = true;
                tileRenderer = tileObject13.GetComponent<MeshRenderer>();
                tileRenderer.material = steppedTileMat;
            }
            else
            {
                reset();
            }

        }

        if (tile == tileObject14)
        {
            if (tile14 == false)
            {
                tile14 = true;
                tileRenderer = tileObject14.GetComponent<MeshRenderer>();
                tileRenderer.material = steppedTileMat;
            }
            else
            {
                reset();
            }

        }

        if (tile == tileObject15)
        {
            if (tile15 == false)
            {
                tile15 = true;
                tileRenderer = tileObject15.GetComponent<MeshRenderer>();
                tileRenderer.material = steppedTileMat;
            }
            else
            {
                reset();
            }

        }
    }

    private void reset()
    {
        if (!completeBool)
        {
            tile1 = false;
            tile2 = false;
            tile3 = false;
            tile4 = false;
            tile5 = false;
            tile6 = false;
            tile7 = false;
            tile8 = false;
            tile9 = false;
            tile10 = false;
            tile11 = false;
            tile12 = false;
            tile13 = false;
            tile14 = false;
            tile15 = false;

            tileRenderer = tileObject1.GetComponent<MeshRenderer>();
            tileRenderer.material = tileMat;
            tileRenderer = tileObject2.GetComponent<MeshRenderer>();
            tileRenderer.material = tileMat;
            tileRenderer = tileObject3.GetComponent<MeshRenderer>();
            tileRenderer.material = tileMat;
            tileRenderer = tileObject4.GetComponent<MeshRenderer>();
            tileRenderer.material = tileMat;
            tileRenderer = tileObject5.GetComponent<MeshRenderer>();
            tileRenderer.material = tileMat;
            tileRenderer = tileObject6.GetComponent<MeshRenderer>();
            tileRenderer.material = tileMat;
            tileRenderer = tileObject7.GetComponent<MeshRenderer>();
            tileRenderer.material = tileMat;
            tileRenderer = tileObject8.GetComponent<MeshRenderer>();
            tileRenderer.material = tileMat;
            tileRenderer = tileObject9.GetComponent<MeshRenderer>();
            tileRenderer.material = tileMat;
            tileRenderer = tileObject10.GetComponent<MeshRenderer>();
            tileRenderer.material = tileMat;
            tileRenderer = tileObject11.GetComponent<MeshRenderer>();
            tileRenderer.material = tileMat;
            tileRenderer = tileObject12.GetComponent<MeshRenderer>();
            tileRenderer.material = tileMat;
            tileRenderer = tileObject13.GetComponent<MeshRenderer>();
            tileRenderer.material = tileMat;
            tileRenderer = tileObject14.GetComponent<MeshRenderer>();
            tileRenderer.material = tileMat;
            tileRenderer = tileObject15.GetComponent<MeshRenderer>();
            tileRenderer.material = tileMat;

            //arrows
            Instantiate(arrow, placement.transform.position, arrow.transform.rotation);

            GameObject projectileGO = (GameObject)Instantiate(arrow, transform.position, arrow.transform.rotation);

            Rigidbody projectileRb = projectileGO.GetComponent<Rigidbody>();
            projectileRb.AddForce(arrowSpeed * Vector3.forward, ForceMode.Impulse);
        }
    }

    private void puzzleComeplete()
    {
        Debug.Log("puzzle Comeplete");
        completeBool = true;

        portal.SetActive(true);

    }
}
