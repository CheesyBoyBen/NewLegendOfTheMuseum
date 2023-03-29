using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController: MonoBehaviour, Interactable
{

    [SerializeField] Dialog dialog;
    public GameObject ONLYPHONE;

    // Start is called before the first frame update
public void Interact()
    {
        
        StartCoroutine(DialogueManager.Instance.ShowDialogue(dialog));

        if (ONLYPHONE != null)
        {
            if (this.gameObject.name == "NPCPhone")
            {
                ONLYPHONE.SetActive(true);
            }
        }
    }
}
