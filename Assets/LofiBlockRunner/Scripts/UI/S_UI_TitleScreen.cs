using UnityEngine;
using UnityEngine.UIElements;

public class S_UI_TitleScreen : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnableTitleScreenUI += EnableUI;
        S_Actions.DisableTitleScreenUI += DisableUI;
    }

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button buttonStart = root.Q<Button>("button-start");
        Button buttonOptions = root.Q<Button>("button-options");
        Button buttonCredits = root.Q<Button>("button-credits");
        Button buttonExit = root.Q<Button>("button-exit");

        buttonStart.clicked += () => S_Actions.StartTutorial();
        buttonOptions.clicked += () => S_Actions.OpenOptionsMenu();
        buttonCredits.clicked += () => S_Actions.OpenCreditsMenu();
        
        buttonExit.clicked += () => Application.Quit();
    }

    private void EnableUI() => this.gameObject.SetActive(true);

    private void DisableUI() => this.gameObject.SetActive(false);
}
