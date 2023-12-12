using UnityEngine;
using System;

public enum CanvasType
{
    MainMenu,
    Settings,
    Credits,
    Tutorial,
    GameUI,
    EndScreen
}

public class S_UIManager : MonoBehaviour
{
    #region Variables
    [SerializeField] private S_CanvasController[] _canvasList;
    private S_CanvasController _lastActiveCanvas;
    #endregion

    #region Functions
    private void Awake()
    {
        // Disable all canvas
        foreach (S_CanvasController canvas in _canvasList) canvas.gameObject.SetActive(false);

        // Register Trigger
        S_Actions.OpenMainMenuUI += () => SwitchCanvas(CanvasType.MainMenu);
        S_Actions.OpenSettingsUI += () => SwitchCanvas(CanvasType.Settings);
        S_Actions.OpenCreditsUI += () => SwitchCanvas(CanvasType.Credits);
        S_Actions.OpenTutorialUI += () => SwitchCanvas(CanvasType.Tutorial);
        S_Actions.OpenGameUI += () => SwitchCanvas(CanvasType.GameUI);
        S_Actions.OpenEndScreenUI += () => SwitchCanvas(CanvasType.EndScreen);
    }

    public void SwitchCanvas(CanvasType _type)
    {
        // Turn of the last canvas
        if (_lastActiveCanvas != null) _lastActiveCanvas.gameObject.SetActive(false);

        // Find the type of the next canvas
        S_CanvasController desiredCanvas = Array.Find(_canvasList,x => x.canvasType == _type);

        // Check if next canvas exists
        if (desiredCanvas != null)
        {
            // Turn on next canvas
            desiredCanvas.gameObject.SetActive(true);
            // Set next canvas as last
            _lastActiveCanvas = desiredCanvas;
        }
        else Debug.LogWarning("The desired canvas was not found!");
    }
    #endregion
}
