using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController: MonoBehaviour, Interactable
{

    [SerializeField] Dialog dialog;
    public GameObject ONLYPHONE;

    public Vector3 targetPos;
    public Vector3 targetRot;
    public GameObject cam;
    private camera camScript;
    private bool inRadius;

    public bool tempNOTOUCH;
    public bool tempNOTOUCH2;

    public AudioSource audioSource;
    public AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        camScript = cam.GetComponent<camera>();
        tempNOTOUCH = false;
        tempNOTOUCH2 = false;
    }

    // Update is called once per frame
    void Update()
    {

            if ((inRadius) && (Input.GetKeyDown(KeyCode.E)))
            {
                if (tempNOTOUCH2 == false)
                {
                    playerEnter();
                    tempNOTOUCH2 = true;
                }
            }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inRadius = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inRadius = false;
        }
    }
    public void Interact()
    {
        if ((tempNOTOUCH == false) && (inRadius))
        {
            StartCoroutine(DialogueManager.Instance.ShowDialogue(dialog, this.GetComponent<NPCController>()));
            tempNOTOUCH = true;
            tempNOTOUCH2 = false;
        }

        if (ONLYPHONE != null)
        {
            if (this.gameObject.name == "NPCPhone")
            {
                ONLYPHONE.SetActive(true);
            }
        }
    }

    void playerEnter()
    {
        camScript.MoveToPos(targetPos, targetRot);

        if ((audioSource != null) && (audioClip != null)) {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
    }

    public void playerExit()
    {
        camScript.MoveToDefault();
    }
}
