using Cinemachine;
using UnityEngine;

public class S_CameraManager : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera[] _cameraList;
    [SerializeField]
    private CinemachineVirtualCamera _startCamera;

    private void Awake()
    {
        // Disable all UI Documents except the first one
        foreach (CinemachineVirtualCamera camera in _cameraList)
        {
            if (camera == _startCamera) camera.gameObject.SetActive(true);
            else camera.gameObject.SetActive(false);
        }
    }
}
