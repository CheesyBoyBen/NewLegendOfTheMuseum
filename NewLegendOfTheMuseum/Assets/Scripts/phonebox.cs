using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class phonebox : MonoBehaviour
{
    private bool trigger;
    public GameObject playerRig;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger)
        {
            transform.eulerAngles += new Vector3(0, 1, 0);
            transform.position += new Vector3(0, 0.05f, 0);

            StartCoroutine(ChangeScene());

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            trigger = true;
            playerRig.SetActive(false);
            player.GetComponent<CharacterController>().enabled = false;
        }
    }

    private IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene("HUBArea");
    }
}
