using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPuzzle : MonoBehaviour
{
    public GameObject player;

    [Header("Planets")]
    public GameObject sun;
    public GameObject planet1;
    public GameObject planet2;
    public GameObject planet3;
    public GameObject planet4;
    public GameObject planet5;
    public GameObject planet6;
    public GameObject planet7;
    public GameObject planet8;




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Vector3.Distance(sun.transform.position, player.transform.position) <= 2f)
            {
                sun.transform.eulerAngles = new Vector3(sun.transform.eulerAngles.x, sun.transform.eulerAngles.y + 45, sun.transform.eulerAngles.z);

                if (sun.transform.eulerAngles.y >= 360)
                {
                    sun.transform.eulerAngles = new Vector3(sun.transform.eulerAngles.x, sun.transform.eulerAngles.y - 360, sun.transform.eulerAngles.z);
                }
                if (sun.transform.eulerAngles.y < 0)
                {
                    sun.transform.eulerAngles = new Vector3(sun.transform.eulerAngles.x, sun.transform.eulerAngles.y + 360, sun.transform.eulerAngles.z);
                }                
            }

            if (Vector3.Distance(planet1.transform.position, player.transform.position) <= 2f)
            {
                planet1.transform.eulerAngles = new Vector3(planet1.transform.eulerAngles.x, planet1.transform.eulerAngles.y + 45, planet1.transform.eulerAngles.z);

                if (planet1.transform.eulerAngles.y >= 360)
                {
                    planet1.transform.eulerAngles = new Vector3(planet1.transform.eulerAngles.x, planet1.transform.eulerAngles.y - 360, planet1.transform.eulerAngles.z);
                }
                if (planet1.transform.eulerAngles.y < 0)
                {
                    planet1.transform.eulerAngles = new Vector3(planet1.transform.eulerAngles.x, planet1.transform.eulerAngles.y + 360, planet1.transform.eulerAngles.z);
                }                
            }

            if (Vector3.Distance(planet2.transform.position, player.transform.position) <= 2f)
            {
                planet2.transform.eulerAngles = new Vector3(planet2.transform.eulerAngles.x, planet2.transform.eulerAngles.y + 45, planet2.transform.eulerAngles.z);

                if (planet2.transform.eulerAngles.y >= 360)
                {
                    planet2.transform.eulerAngles = new Vector3(planet2.transform.eulerAngles.x, planet2.transform.eulerAngles.y - 360, planet2.transform.eulerAngles.z);
                }
                if (planet2.transform.eulerAngles.y < 0)
                {
                    planet2.transform.eulerAngles = new Vector3(planet2.transform.eulerAngles.x, planet2.transform.eulerAngles.y + 360, planet2.transform.eulerAngles.z);
                }
            }

            if (Vector3.Distance(planet3.transform.position, player.transform.position) <= 2f)
            {
                planet3.transform.eulerAngles = new Vector3(planet3.transform.eulerAngles.x, planet3.transform.eulerAngles.y + 45, planet3.transform.eulerAngles.z);

                if (planet3.transform.eulerAngles.y >= 360)
                {
                    planet3.transform.eulerAngles = new Vector3(planet3.transform.eulerAngles.x, planet3.transform.eulerAngles.y - 360, planet3.transform.eulerAngles.z);
                }
                if (planet3.transform.eulerAngles.y < 0)
                {
                    planet3.transform.eulerAngles = new Vector3(planet3.transform.eulerAngles.x, planet3.transform.eulerAngles.y + 360, planet3.transform.eulerAngles.z);
                }
            }

            if (Vector3.Distance(planet4.transform.position, player.transform.position) <= 2f)
            {
                planet4.transform.eulerAngles = new Vector3(planet4.transform.eulerAngles.x, planet4.transform.eulerAngles.y + 45, planet4.transform.eulerAngles.z);

                if (planet4.transform.eulerAngles.y >= 360)
                {
                    planet4.transform.eulerAngles = new Vector3(planet4.transform.eulerAngles.x, planet4.transform.eulerAngles.y - 360, planet4.transform.eulerAngles.z);
                }
                if (planet4.transform.eulerAngles.y < 0)
                {
                    planet4.transform.eulerAngles = new Vector3(planet4.transform.eulerAngles.x, planet4.transform.eulerAngles.y + 360, planet4.transform.eulerAngles.z);
                }
            }

            if (Vector3.Distance(planet5.transform.position, player.transform.position) <= 2f)
            {
                planet5.transform.eulerAngles = new Vector3(planet5.transform.eulerAngles.x, planet5.transform.eulerAngles.y + 45, planet5.transform.eulerAngles.z);

                if (planet5.transform.eulerAngles.y >= 360)
                {
                    planet5.transform.eulerAngles = new Vector3(planet5.transform.eulerAngles.x, planet5.transform.eulerAngles.y - 360, planet5.transform.eulerAngles.z);
                }
                if (planet5.transform.eulerAngles.y < 0)
                {
                    planet5.transform.eulerAngles = new Vector3(planet5.transform.eulerAngles.x, planet5.transform.eulerAngles.y + 360, planet5.transform.eulerAngles.z);
                }
            }

            if (Vector3.Distance(planet6.transform.position, player.transform.position) <= 2f)
            {
                planet6.transform.eulerAngles = new Vector3(planet6.transform.eulerAngles.x, planet6.transform.eulerAngles.y + 45, planet6.transform.eulerAngles.z);

                if (planet6.transform.eulerAngles.y >= 360)
                {
                    planet6.transform.eulerAngles = new Vector3(planet6.transform.eulerAngles.x, planet6.transform.eulerAngles.y - 360, planet6.transform.eulerAngles.z);
                }
                if (planet6.transform.eulerAngles.y < 0)
                {
                    planet6.transform.eulerAngles = new Vector3(planet6.transform.eulerAngles.x, planet6.transform.eulerAngles.y + 360, planet6.transform.eulerAngles.z);
                }
            }

            if (Vector3.Distance(planet7.transform.position, player.transform.position) <= 2f)
            {
                planet7.transform.eulerAngles = new Vector3(planet7.transform.eulerAngles.x, planet7.transform.eulerAngles.y + 45, planet7.transform.eulerAngles.z);

                if (planet7.transform.eulerAngles.y >= 360)
                {
                    planet7.transform.eulerAngles = new Vector3(planet7.transform.eulerAngles.x, planet7.transform.eulerAngles.y - 360, planet7.transform.eulerAngles.z);
                }
                if (planet7.transform.eulerAngles.y < 0)
                {
                    planet7.transform.eulerAngles = new Vector3(planet7.transform.eulerAngles.x, planet7.transform.eulerAngles.y + 360, planet7.transform.eulerAngles.z);
                }
            }

            if (Vector3.Distance(planet8.transform.position, player.transform.position) <= 2f)
            {
                planet8.transform.eulerAngles = new Vector3(planet8.transform.eulerAngles.x, planet8.transform.eulerAngles.y + 45, planet8.transform.eulerAngles.z);

                if (planet8.transform.eulerAngles.y >= 360)
                {
                    planet8.transform.eulerAngles = new Vector3(planet8.transform.eulerAngles.x, planet8.transform.eulerAngles.y - 360, planet8.transform.eulerAngles.z);
                }
                if (planet8.transform.eulerAngles.y < 0)
                {
                    planet8.transform.eulerAngles = new Vector3(planet8.transform.eulerAngles.x, planet8.transform.eulerAngles.y + 360, planet8.transform.eulerAngles.z);
                }
            }
        }


        CheckRotations();
    }


    void CheckRotations()
    {
                
        if ((Mathf.Round(sun.transform.eulerAngles.y) == ((45 * 3) - 45)) && (sun.GetComponent<LineRenderer>().enabled))
        {
            planet1.GetComponent<LineRenderer>().enabled = true;
        }
        else
        {
            planet1.GetComponent<LineRenderer>().enabled = false;

        }

        if ((Mathf.Round(planet1.transform.eulerAngles.y) == ((45 * 1) - 45)) && (planet1.GetComponent<LineRenderer>().enabled))
        {
            planet2.GetComponent<LineRenderer>().enabled = true;

        }
        else
        {
            planet2.GetComponent<LineRenderer>().enabled = false;

        }

        if ((Mathf.Round(planet2.transform.eulerAngles.y) == 226) && (planet2.GetComponent<LineRenderer>().enabled))
        {
            planet3.GetComponent<LineRenderer>().enabled = true;

        }
        else
        {
            planet3.GetComponent<LineRenderer>().enabled = false;

        }

        if ((Mathf.Round(planet3.transform.eulerAngles.y) == ((45 * 1) - 45)) && (planet3.GetComponent<LineRenderer>().enabled))
        {
            planet4.GetComponent<LineRenderer>().enabled = true;

        }
        else
        {
            planet4.GetComponent<LineRenderer>().enabled = false;

        }

        if ((Mathf.Round(planet4.transform.eulerAngles.y) == ((45 * 4) - 45)) && (planet4.GetComponent<LineRenderer>().enabled))
        {
            planet5.GetComponent<LineRenderer>().enabled = true;
        }
        else
        {
            planet5.GetComponent<LineRenderer>().enabled = false;

        }

        if ((Mathf.Round(planet5.transform.eulerAngles.y) == ((45 * 1) - 45)) && (planet5.GetComponent<LineRenderer>().enabled))
        {
            planet6.GetComponent<LineRenderer>().enabled = true;
        }
        else
        {
            planet6.GetComponent<LineRenderer>().enabled = false;

        }

        if ((Mathf.Round(planet6.transform.eulerAngles.y) == ((45 * 7) - 45)) && (planet6.GetComponent<LineRenderer>().enabled))
        {
            planet7.GetComponent<LineRenderer>().enabled = true;
        }
        else
        {
            planet7.GetComponent<LineRenderer>().enabled = false;

        }

        if ((Mathf.Round(planet7.transform.eulerAngles.y) == ((45 * 2) - 45)) && (planet7.GetComponent<LineRenderer>().enabled))
        {
            planet8.GetComponent<LineRenderer>().enabled = true;
        }
        else
        {
            planet8.GetComponent<LineRenderer>().enabled = false;

        }
    }
}
