using UnityEngine;
using UnityEngine.UIElements;

/// <summary>  
/// Class handling the pause UI
/// </summary>
public class S_UI_Pause : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnablePauseUI += () => this.gameObject.SetActive(true);
        S_Actions.DisablePauseUI += () => this.gameObject.SetActive(false);
    }
    private void OnEnable()
    {
        // Get the UI DOM
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        // Get all buttons and texts
        Label currentScore = root.Q<Label>("current-score-value");
        Label highScore = root.Q<Label>("high-score-value");
        Button buttonResume = root.Q<Button>("button-resume");
        Button buttonOptions = root.Q<Button>("button-options");
        Button buttonQuit = root.Q<Button>("button-quit");

        // Set texts values
        currentScore.text = "Pegar esse texto do input";
        highScore.text = "Pegar esse texto do input";

        // Set buttons behaviors
        buttonResume.clicked += () => S_Actions.OpenGame();
        buttonOptions.clicked += () => S_Actions.OpenOptions();
        buttonQuit.clicked += () =>  S_Actions.OpenTitleScreen();
    }
}
