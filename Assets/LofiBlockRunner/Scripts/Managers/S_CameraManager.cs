using Cinemachine;
using UnityEngine;

/// <summary>  
/// Class responsible for deactivating all cameras, and then enable a chosen one
/// </summary>
public class S_CameraManager : MonoBehaviour
{
    #region Variables
    [Header("Cameras Settings")]
    [Tooltip("List with all cameras.")]
    [SerializeField] private CinemachineVirtualCamera[] _cameraList;
    [Tooltip("Camera that will remain active.")]
    [SerializeField] private CinemachineVirtualCamera _startCamera;
    #endregion

    #region Functions
    private void Start()
    {
        // Deactivate all cameras except the start one
        foreach (CinemachineVirtualCamera camera in _cameraList)
        {
            if (camera == _startCamera) camera.gameObject.SetActive(true);
            else camera.gameObject.SetActive(false);
        }
    }
    #endregion
}
