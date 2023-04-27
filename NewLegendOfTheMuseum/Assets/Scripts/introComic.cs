using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class introComic : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public TMP_Text TMP;
    // Start is called before the first frame update
    void Start()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);

        StartCoroutine(cut1());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator cut1()
    {
        TMP.text = "On a nice, busy day at the National Museums Scotland in Edinburgh";
        yield return new WaitForSeconds(3f);
        TMP.text = "";

        StartCoroutine(cut2());
    }

    IEnumerator cut2()
    {
        panel1.SetActive(true);
        yield return new WaitForSeconds(3f);
        panel1.SetActive(false);

        StartCoroutine(cut3());
    }

    IEnumerator cut3()
    {
        TMP.text = "Dolly spots a new mysterious artefact added to the collection";
        yield return new WaitForSeconds(2f);
        TMP.text = "";

        StartCoroutine(cut4());
    }

    IEnumerator cut4()
    {
        panel2.SetActive(true);
        yield return new WaitForSeconds(2f);
        panel2.SetActive(false);

        StartCoroutine(cut5());
    }

    IEnumerator cut5()
    {
        TMP.text = "The museum would never be the same";
        yield return new WaitForSeconds(2f);
        TMP.text = "";

        StartCoroutine(cut6());
    }

    IEnumerator cut6()
    {
        panel3.SetActive(true);
        yield return new WaitForSeconds(2f);
        panel3.SetActive(false);

        StartCoroutine(cut7());
    }

    IEnumerator cut7()
    {
        panel4.SetActive(true);
        yield return new WaitForSeconds(2f);
        panel4.SetActive(false);

        StartCoroutine(cut8());
    }

    IEnumerator cut8()
    {
        TMP.text = "Dolly's journey awaits";
        yield return new WaitForSeconds(6f);
        TMP.text = "";

        scene();
    }

    void scene()
    {
        SceneManager.LoadScene("HUBArea");
    }
}
