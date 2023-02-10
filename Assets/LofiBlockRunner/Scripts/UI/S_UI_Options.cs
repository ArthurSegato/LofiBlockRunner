using UnityEngine;
using UnityEngine.UIElements;

public class S_UI_Options : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnableOptionsUI += EnableUI;
        S_Actions.DisableOptionsUI += DisableUI;
    }

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button buttonBack = root.Q<Button>("button-back");

        buttonBack.clicked += () => S_Actions.OpenTitleScreenMenu();
    }

    private void EnableUI() => this.gameObject.SetActive(true);

    private void DisableUI() => this.gameObject.SetActive(false);
}
