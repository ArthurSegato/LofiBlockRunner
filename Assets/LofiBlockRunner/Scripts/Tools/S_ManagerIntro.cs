using UnityEngine;
using UnityEngine.Video;

/// <summary>  
/// Class handling the intro video
/// </summary>
public class S_ManagerIntro : MonoBehaviour
{
    #region Variables
    [Header("Video Settings")]
    [Tooltip("Video player in which the intro will play.")]
    [SerializeField] private VideoPlayer _videoPlayer;
    #endregion

    #region Methods
    // Make video player load the video file
    private void Awake() => _videoPlayer.Prepare();

    // Play the video file
    private void PlayVideo() => _videoPlayer.Play();
    #endregion
}
