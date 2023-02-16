using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController: MonoBehaviour, Interactable
{

    [SerializeField] Dialog dialog;

    // Start is called before the first frame update
public void Interact()
    {
        
        StartCoroutine(DialogueManager.Instance.ShowDialogue(dialog));
    }
}
