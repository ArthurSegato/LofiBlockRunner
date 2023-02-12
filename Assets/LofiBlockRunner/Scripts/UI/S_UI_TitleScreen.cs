using UnityEngine;
using UnityEngine.UIElements;

/// <summary>  
/// Class handling the title screen UI
/// </summary>
public class S_UI_TitleScreen : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnableTitleScreenUI += () => this.gameObject.SetActive(true);
        S_Actions.DisableTitleScreenUI += () => this.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        // Get the UI DOM
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        // Get all buttons
        Button buttonStart = root.Q<Button>("button-start");
        Button buttonOptions = root.Q<Button>("button-options");
        Button buttonCredits = root.Q<Button>("button-credits");
        Button buttonExit = root.Q<Button>("button-exit");

        // Set buttons behaviors
        buttonStart.clicked += () => S_Actions.OpenTutorial();
        buttonOptions.clicked += () => S_Actions.OpenOptions();
        buttonCredits.clicked += () => S_Actions.OpenCredits();
        buttonExit.clicked += () => Application.Quit();
    }
}
