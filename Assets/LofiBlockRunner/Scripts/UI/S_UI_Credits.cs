using UnityEngine;
using UnityEngine.UIElements;

public class S_UI_Credits : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnableCreditsUI += EnableUI;
        S_Actions.DisableCreditsUI += DisableUI;
    }
    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button buttonProgrammer = root.Q<Button>("button-programmer");
        Button buttonSoundDesign = root.Q<Button>("button-sound");
        Button buttonFonts = root.Q<Button>("button-fonts");
        Button buttonMoral = root.Q<Button>("button-support");
        Button buttonBack = root.Q<Button>("button-back");

        buttonProgrammer.clicked += () => Application.OpenURL("https://github.com/ArthurSegato");
        buttonSoundDesign.clicked += () => Application.OpenURL("https://www.instagram.com/lilorecording/");
        buttonFonts.clicked += () => Application.OpenURL("https://fonts.google.com/specimen/Roboto");
        buttonMoral.clicked += () => Application.OpenURL("https://www.instagram.com/dr.ramon.ferraz/");

        buttonBack.clicked += () => S_Actions.OpenTitleScreenMenu();
    }
    private void EnableUI() => this.gameObject.SetActive(true);

    private void DisableUI() => this.gameObject.SetActive(false);
}
