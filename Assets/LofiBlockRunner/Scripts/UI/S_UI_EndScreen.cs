using UnityEngine;
using UnityEngine.UIElements;

/// <summary>  
/// Class handling the game over UI
/// </summary>
public class S_UI_EndScreen : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnableEndScreenUI += () => this.gameObject.SetActive(true);
        S_Actions.DisableEndScreenUI += () => this.gameObject.SetActive(false);
    }
    private void OnEnable()
    {
        // Get the UI DOM
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        // Get all buttons and texts
        Label currentScore = root.Q<Label>("current-score-value");
        Label highScore = root.Q<Label>("high-score-value");
        Button buttonTryAgain = root.Q<Button>("button-tryagain");
        Button buttonTitleScreen = root.Q<Button>("button-mainmenu");

        // Change text values
        currentScore.text = "Pegar esse texto do input";
        highScore.text = "Pegar esse texto do input";

        // Assing buttons behaviors
        buttonTryAgain.clicked += () => S_Actions.OpenGame();
        buttonTitleScreen.clicked += () => S_Actions.OpenTitleScreen();
    }
}
