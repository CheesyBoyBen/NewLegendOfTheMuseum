using UnityEngine;
using UnityEngine.Video;

public class PlayVideoAndQuit : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string url;

    private void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.url = url;
        videoPlayer.loopPointReached += EndReached;
        videoPlayer.Play();
    }

    void Update()
    {
        if (Input.anyKey)
        {
            Play();
        }

    }

    void Play()
    {
        videoPlayer.Play();
        videoPlayer.isLooping = true;
    }


private void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        Application.Quit();
    }
}
