using UnityEngine;
using System;

public enum CanvasType
{
    MainMenu,
    Settings,
    Credits,
    Tutorial,
    Game,
    GameOver
}

/// <summary>  
/// Handles UI changes
/// </summary>
public class S_UIManager : MonoBehaviour
{
    #region Variables
    [SerializeField] private S_CanvasController[] _canvasList;
    private S_CanvasController _lastActiveCanvas;
    #endregion

    #region Methods
    private void Awake()
    {
        // Disable all canvas
        foreach (S_CanvasController canvas in _canvasList) canvas.gameObject.SetActive(false);
	
        // Register Trigger
        S_Actions.UI_Enable_MainMenu += () => SwitchCanvas(CanvasType.MainMenu);
        S_Actions.UI_Enable_Settings += () => SwitchCanvas(CanvasType.Settings);
        S_Actions.UI_Enable_Credits += () => SwitchCanvas(CanvasType.Credits);
        S_Actions.UI_Enable_Tutorial += () => SwitchCanvas(CanvasType.Tutorial);
        S_Actions.UI_Enable_Game += () => SwitchCanvas(CanvasType.Game);
        S_Actions.UI_Enable_GameOver += () => SwitchCanvas(CanvasType.GameOver);
    }

    private void OnDestroy()
    {
        S_Actions.UI_Enable_MainMenu -= () => SwitchCanvas(CanvasType.MainMenu);
        S_Actions.UI_Enable_Settings -= () => SwitchCanvas(CanvasType.Settings);
        S_Actions.UI_Enable_Credits -= () => SwitchCanvas(CanvasType.Credits);
        S_Actions.UI_Enable_Tutorial -= () => SwitchCanvas(CanvasType.Tutorial);
        S_Actions.UI_Enable_Game -= () => SwitchCanvas(CanvasType.Game);
        S_Actions.UI_Enable_GameOver -= () => SwitchCanvas(CanvasType.GameOver);
    }

    public void SwitchCanvas(CanvasType _type)
    {
        // Search for the desired camera
        S_CanvasController desiredCanvas = Array.Find(_canvasList,x => x.canvasType == _type);
        
        // If dind find it, exit earlier and throw warning 
        if (desiredCanvas == null) Debug.LogWarning("The desired canvas was not found!");
        else
        {
            // Turn off the last canvas
            if (_lastActiveCanvas != null) _lastActiveCanvas.gameObject.SetActive(false);
            // Update last camera
            _lastActiveCanvas = desiredCanvas;
            // Turn on desired canvas
            desiredCanvas.gameObject.SetActive(true);
        }
    }
    #endregion
}
