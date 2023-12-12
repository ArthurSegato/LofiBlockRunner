using UnityEngine;
using System;

public enum CameraType
{
    MainMenu,
    Settings,
    Credits,
    Game
}

public class S_CameraManager : MonoBehaviour
{
    #region Variables
    [SerializeField] private S_CameraController[] _cameraList;
    private S_CameraController _lastActiveCamera;
    #endregion

    #region Functions
    private void Awake()
    {
        // Disable all cameras
        foreach (S_CameraController camera in _cameraList) camera.gameObject.SetActive(false);

        // Register Trigger
        S_Actions.EnableMainMenuCamera += () => SwitchCamera(CameraType.MainMenu);
        S_Actions.EnableSettingsCamera += () => SwitchCamera(CameraType.Settings);
        S_Actions.EnableCreditsCamera += () => SwitchCamera(CameraType.Credits);
        S_Actions.EnableGameCamera += () => SwitchCamera(CameraType.Game);
    }

    public void SwitchCamera(CameraType _type)
    {
        // Turn off the last camera
        if (_lastActiveCamera != null) _lastActiveCamera.gameObject.SetActive(false);

        // Find the type of the next camera
        S_CameraController desiredCamera = Array.Find(_cameraList, x => x.cameraType == _type);

        // Check if next camera exists
        if (desiredCamera != null)
        {
            // Turn on next camera
            desiredCamera.gameObject.SetActive(true);
            // Set next camera as last
            _lastActiveCamera = desiredCamera;
        }
        else Debug.LogWarning("The desired camera was not found!");
    }
    #endregion
}
