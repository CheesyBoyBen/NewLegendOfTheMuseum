using UnityEngine;
using UnityEngine.Video;

public class PlayVideoAndQuit : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private void Start()
    {
        videoPlayer.loopPointReached += EndReached;
        videoPlayer.Play();
    }

    private void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        Application.Quit();
    }
}
