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
    public TextMeshProUGUI TMPEnglish;
    public TextMeshProUGUI TMPMorse;
    public GameObject portal;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.E)) && (morse != sequence))
        {
            if (Vector3.Distance(dot.transform.position, player.transform.position) <= 5f)
            {
                morse = morse + "0";
                Debug.Log(morse);
                TMPMorse.text += ".";
            }

            if (Vector3.Distance(dash.transform.position, player.transform.position) <= 5f)
            {
                morse = morse + "1";
                Debug.Log(morse);
                TMPMorse.text += "-";

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
                        TMPEnglish.text = "D"; 
                        TMPMorse.text += " ";

                    }
                    else
                    {
                        Debug.Log("incorrect");
                        morse = "";
                        TMPMorse.text = "";

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
                        TMPEnglish.text = "DO";
                        TMPMorse.text += " ";

                    }
                    else
                    {
                        Debug.Log("incorrect");
                        morse = "100";
                        TMPMorse.text = "-.. ";

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
                        TMPEnglish.text = "DOL";
                        TMPMorse.text += " ";

                    }
                    else
                    {
                        Debug.Log("incorrect");
                        morse = "100111";
                        TMPMorse.text = "-.. --- ";

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
                        TMPEnglish.text = "DOLL";
                        TMPMorse.text += " ";

                    }
                    else
                    {
                        Debug.Log("incorrect");
                        morse = "1001110100";
                        TMPMorse.text = "-.. --- .-.. ";

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
                        TMPEnglish.text = "DOLLY";

                    }
                    else
                    {
                        Debug.Log("incorrect");
                        morse = "10011101000100";
                        TMPMorse.text = "-.. --- .-.. .-.. ";

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
                    TMPMorse.text = "-.. --- .-.. .-.. -.--";

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
