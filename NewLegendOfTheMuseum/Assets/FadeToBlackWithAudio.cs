
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeToBlackWithAudio : MonoBehaviour
{
    public float fadeTime = 1f;
    public AudioClip audioClip;
    private Image blackImage;
    private AudioSource audioSource;

    void Start()
    {
        blackImage = GetComponent<Image>();
        blackImage.color = new Color(0f, 0f, 0f, 0f);
        audioSource = GetComponent<AudioSource>();
    }

    public IEnumerator PlayAudioAndFadeOut()
    {
        // Play the audio clip
        if (audioClip != null)
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }

        // Wait for the audio clip to finish playing
        yield return new WaitForSeconds(audioClip.length);

        // Fade to black
        float elapsedTime = 0f;
        while (elapsedTime < fadeTime)
        {
            float alpha = Mathf.Lerp(0f, 1f, elapsedTime / fadeTime);
            blackImage.color = new Color(0f, 0f, 0f, alpha);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
}
