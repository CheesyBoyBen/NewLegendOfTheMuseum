using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip startClip;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudio(AudioClip newAudio)
    {
        audio.clip = newAudio;
        audio.Play();
    }
}
