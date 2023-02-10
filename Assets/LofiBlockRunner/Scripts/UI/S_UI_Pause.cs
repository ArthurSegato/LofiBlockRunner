using UnityEngine;
using UnityEngine.UIElements;

public class S_UI_Pause : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnablePauseUI += EnableUI;
        S_Actions.DisablePauseUI += DisableUI;
    }
    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Label currentScore = root.Q<Label>("current-score-value");
        Label highScore = root.Q<Label>("high-score-value");
        Button buttonResume = root.Q<Button>("button-resume");
        Button buttonOptions = root.Q<Button>("button-options");
        Button buttonQuit = root.Q<Button>("button-quit");

        currentScore.text = "Pegar esse texto do input";
        highScore.text = "Pegar esse texto do input";

        buttonResume.clicked += () => S_Actions.StartGame();
        buttonOptions.clicked += () => S_Actions.OpenOptionsMenu();
        buttonQuit.clicked += () => S_Actions.OpenTitleScreenMenu();
    }
    private void EnableUI() => this.gameObject.SetActive(true);

    private void DisableUI() => this.gameObject.SetActive(false);
}
