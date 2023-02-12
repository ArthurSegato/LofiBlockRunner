using UnityEngine;
using UnityEngine.UIElements;

/// <summary>  
/// Class handling the options UI
/// </summary>
public class S_UI_Options : MonoBehaviour
{
    private bool isPaused = false;
    private void Awake()
    {
        S_Actions.EnableOptionsUI += () => this.gameObject.SetActive(true);
        S_Actions.DisableOptionsUI += () => this.gameObject.SetActive(false);
        S_Actions.PauseGame += () => isPaused = true;
        S_Actions.OpenGame += () => isPaused = false;
    }

    private void OnEnable()
    {
        // Get the UI DOM
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        // Get all buttons
        Button buttonBack = root.Q<Button>("button-back");

        // Set button behavior
        buttonBack.clicked += ChangeStates;
    }

    private void ChangeStates()
    {
        if (!isPaused) S_Actions.OpenTitleScreen();
        else S_Actions.PauseGame();
    }
}
