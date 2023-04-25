using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoPlayerScript : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private void Start()
    {
        videoPlayer.Play();
        Invoke("LoadNextScene", (float)videoPlayer.clip.length);
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene("HUBArea");
    }
}
