using System.Collections;
using UnityEngine;
using UnityEngine.Video;

public class S_IntroManager : MonoBehaviour
{
    [SerializeField]
    private VideoPlayer videoPlayer;

    private void OnEnable() => S_Actions.OnPlayIntro += PlayVideo;

    private void OnDisable() => S_Actions.OnPlayIntro -= PlayVideo;

    private void Awake()
    {
        videoPlayer.Prepare();
    }
    private void PlayVideo()
    {
        videoPlayer.Play();
    }

}
