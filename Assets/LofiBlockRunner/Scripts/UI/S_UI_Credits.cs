using UnityEngine;
using UnityEngine.UIElements;

/// <summary>  
/// Class handling the credit UI
/// </summary>
public class S_UI_Credits : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnableCreditsUI += () => this.gameObject.SetActive(true);
        S_Actions.DisableCreditsUI += () => this.gameObject.SetActive(false);
    }
    private void OnEnable()
    {
        // Get the UI DOM
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        // Get all buttons
        Button buttonProgrammer = root.Q<Button>("button-programmer");
        Button buttonSoundDesign = root.Q<Button>("button-sound");
        Button buttonFonts = root.Q<Button>("button-fonts");
        Button buttonMoral = root.Q<Button>("button-support");
        Button buttonBack = root.Q<Button>("button-back");

        // Assing buttons behaviors
        buttonProgrammer.clicked += () => Application.OpenURL("https://github.com/ArthurSegato");
        buttonSoundDesign.clicked += () => Application.OpenURL("https://www.instagram.com/lilorecording/");
        buttonFonts.clicked += () => Application.OpenURL("https://fonts.google.com/specimen/Roboto");
        buttonMoral.clicked += () => Application.OpenURL("https://www.instagram.com/dr.ramon.ferraz/");
        buttonBack.clicked += () => S_Actions.OpenTitleScreen();
    }
}
