using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState {  FreeRoam, Dialog}

public class GameController : MonoBehaviour
{

    GameState state;

    [SerializeField] PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        DialogueManager.Instance.OnShowDialog += () =>
        {
            state = GameState.Dialog;
        };
        DialogueManager.Instance.OnCloseDialog += () =>
        {
            if(state == GameState.Dialog)
            state = GameState.FreeRoam;

        };
    }

    // Update is called once per frame
    void Update()
    {
        if (state == GameState.FreeRoam)
        {

            playerMovement.HandleUpdate();
        }
        else if (state == GameState.Dialog)
        {
            DialogueManager.Instance.HandleUpdate();
        }
    }
}
