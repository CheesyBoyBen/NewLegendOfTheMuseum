using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public GameObject OptionsScreen;
   public void LoadHub()
    {
        SceneManager.LoadScene("IntroVideo");
    }

    public void EndGame()
    {
        Application.Quit();
    
    }

    public void Options()
    {
        OptionsScreen.SetActive(true);
    }

    public void EndOptions()
    {
        OptionsScreen.SetActive(false);
    }

}
