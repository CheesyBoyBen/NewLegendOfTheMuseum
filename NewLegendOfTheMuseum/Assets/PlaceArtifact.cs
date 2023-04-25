using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaceArtifact : MonoBehaviour
{
    public PlayerMovement pm;
    public GameObject artifact;
    public string sceneToLoad;

    private bool canAdd;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canAdd)
        {
            artifact.SetActive(true);
            Invoke("LoadNextScene", 5f);
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene("OutroVideo");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canAdd = true;
        }
    }
}
