using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DialogueManager : MonoBehaviour
{
   [SerializeField] GameObject dialogueBox;
    [SerializeField] TMP_Text dialogText;
   [SerializeField] int lettersPerSecond;

    private NPCController activeInstance;

    public event Action OnShowDialog;
    public event Action OnCloseDialog;

    public static DialogueManager Instance { get; private set; }

    private void Awake()
    {

        Instance = this;
    }

    Dialog dialog;
    int currentLine = 0;
    bool isTyping;

    public IEnumerator ShowDialogue(Dialog dialog, NPCController instance)
    {
        yield return new WaitForEndOfFrame();
        OnShowDialog?.Invoke();

        this.dialog = dialog;
        dialogueBox.SetActive(true);
        StartCoroutine(TypeDialog(dialog.Lines[0]));
        activeInstance = instance;
    }

    public void HandleUpdate()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isTyping)
        {
            ++currentLine;
            if(currentLine < dialog.Lines.Count)
            {
                StartCoroutine(TypeDialog(dialog.Lines[currentLine]));
            }
            else
            {
                currentLine = 0;
                dialogueBox.SetActive(false);
                OnCloseDialog?.Invoke();
                activeInstance.playerExit();
                activeInstance.tempNOTOUCH = false;
            }
        }
    }

    public IEnumerator TypeDialog(string line)
    {
        isTyping = true;
        dialogText.text = " ";
        foreach (var letter in line.ToCharArray())
        {
            dialogText.text += letter;
            yield return new WaitForSeconds(1f / lettersPerSecond);
        }
        isTyping = false;
    }
}
