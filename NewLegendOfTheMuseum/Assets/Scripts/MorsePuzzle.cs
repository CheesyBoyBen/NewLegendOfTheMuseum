using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MorsePuzzle : MonoBehaviour
{
    public string sequence;
    private string morse;
    private string inputEnglish;
    public GameObject dot;
    public GameObject dash;
    public GameObject player;
    public TextMeshProUGUI TMP;
    public GameObject portal;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Vector3.Distance(dot.transform.position, player.transform.position) <= 5f)
            {
                morse = morse + "0";
                Debug.Log(morse);

            }

            if (Vector3.Distance(dash.transform.position, player.transform.position) <= 5f)
            {
                morse = morse + "1";
                Debug.Log(morse);
            }
        }


        if (inputEnglish == null)
        {
            if (morse != null)
            {
                if (morse.Length == 3)
                {
                    if (morse == "100")
                    {
                        Debug.Log("D");
                        inputEnglish = "D";
                        TMP.text = "D";
                    }
                    else
                    {
                        Debug.Log("incorrect");
                        morse = "";
                    }
                }
            }
        }

        else if (inputEnglish == "D")
        {
            if (morse != null)
            {
                if (morse.Length == 6)
                {
                    if (morse == "100111")
                    {
                        Debug.Log("DO");
                        inputEnglish = "DO";
                        TMP.text = "DO";

                    }
                    else
                    {
                        Debug.Log("incorrect");
                        morse = "100";
                    }
                }
            }
        }

        else if (inputEnglish == "DO")
        {
            if (morse != null)
            {
                if (morse.Length == 10)
                {
                    if (morse == "1001110100")
                    {
                        Debug.Log("DOL");
                        inputEnglish = "DOL";
                        TMP.text = "DOL";

                    }
                    else
                    {
                        Debug.Log("incorrect");
                        morse = "100111";
                    }
                }
            }
        }

        else if (inputEnglish == "DOL")
        {
            if (morse != null)
            {
                if (morse.Length == 14)
                {
                    if (morse == "10011101000100")
                    {
                        Debug.Log("DOLL");
                        inputEnglish = "DOLL";
                        TMP.text = "DOLL";

                    }
                    else
                    {
                        Debug.Log("incorrect");
                        morse = "1001110100";
                    }
                }
            }
        }

        else if (inputEnglish == "DOLL")
        {
            if (morse != null)
            {
                if (morse.Length == 18)
                {
                    if (morse == "100111010001001011")
                    {
                        Debug.Log("DOLLY");
                        inputEnglish = "DOLLY";
                        TMP.text = "DOLLY";

                    }
                    else
                    {
                        Debug.Log("incorrect");
                        morse = "10011101000100";
                    }
                }
            }
        }



        if (morse != null)
        {
            if (morse.Length == 18)
            {
                if (morse == sequence)
                {
                    puzzleComplete();
                    morse = "";
                }
                else
                {
                    Debug.Log("incorrect");
                    morse = "";
                }
            }
        }
    }

    private void puzzleComplete()
    {
        Debug.Log("puzzle complete");
        portal.SetActive(true);
    }
}
