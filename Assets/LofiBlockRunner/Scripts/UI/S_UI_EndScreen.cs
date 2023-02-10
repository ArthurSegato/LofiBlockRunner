using UnityEngine;
using UnityEngine.UIElements;

public class S_UI_EndScreen : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnableEndScreenUI += EnableUI;
        S_Actions.DisableEndScreenUI += DisableUI;
    }
    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Label currentScore = root.Q<Label>("current-score-value");
        Label highScore = root.Q<Label>("high-score-value");
        Button buttonTryAgain = root.Q<Button>("button-tryagain");
        Button buttonTitleScreen = root.Q<Button>("button-mainmenu");


        currentScore.text = "Pegar esse texto do input";
        highScore.text = "Pegar esse texto do input";

        buttonTryAgain.clicked += () => S_Actions.StartGame();
        buttonTitleScreen.clicked += () => S_Actions.OpenTitleScreenMenu();
    }
    private void EnableUI() => this.gameObject.SetActive(true);

    private void DisableUI() => this.gameObject.SetActive(false);
}
