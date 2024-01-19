using UnityEngine;
using System;

public enum CameraType
{
    MainMenu,
    Settings,
    Credits,
    Game
}

/// <summary>  
/// Controls camera logic
/// </summary>
public class S_CameraManager : MonoBehaviour
{
    #region Variables
    [SerializeField] private S_CameraController[] _cameraList;
    private S_CameraController _lastActiveCamera;
    #endregion

    #region Methods
    private void Awake()
    {
        // Disable all cameras
        foreach (S_CameraController camera in _cameraList) camera.gameObject.SetActive(false);

        // Register triggers
        S_Actions.Camera_Enable_MainMenu += () => SwitchCamera(CameraType.MainMenu);
        S_Actions.Camera_Enable_Settings += () => SwitchCamera(CameraType.Settings);
        S_Actions.Camera_Enable_Credits += () => SwitchCamera(CameraType.Credits);
        S_Actions.Camera_Enable_Game += () => SwitchCamera(CameraType.Game);
    }

    private void OnDestroy()
    {
        // Unregister triggers
        S_Actions.Camera_Enable_MainMenu -= () => SwitchCamera(CameraType.MainMenu);
        S_Actions.Camera_Enable_Settings -= () => SwitchCamera(CameraType.Settings);
        S_Actions.Camera_Enable_Credits -= () => SwitchCamera(CameraType.Credits);
        S_Actions.Camera_Enable_Game -= () => SwitchCamera(CameraType.Game);
    }

    private void SwitchCamera(CameraType _type)
    {
        // Search for the desired camera
        S_CameraController desiredCamera = Array.Find(_cameraList, x => x.cameraType == _type);

        // If dind find it, exit early by throwing a warning
        if (desiredCamera == null) Debug.LogWarning("The desired camera was not found!");
        
        else
        {
            // Turn off the last camera
            if (_lastActiveCamera != null) _lastActiveCamera.gameObject.SetActive(false);
            // Update last camera
            _lastActiveCamera = desiredCamera;
            // Turn on desired camera
            desiredCamera.gameObject.SetActive(true);
        }
    }
    #endregion
}
