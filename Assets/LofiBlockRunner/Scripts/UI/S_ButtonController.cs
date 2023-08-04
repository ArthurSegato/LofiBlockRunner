using UnityEngine;
using UnityEngine.UI;

public enum ButtonType
{
    Start_Game,
    Open_Options,
    Open_Credits,
    Quit_Game,
    Resume_Game,
    Open_MainMenu,
    Open_Programmer,
    Open_Sfx,
    Open_Font,
    Open_MoralSupport
}

[RequireComponent(typeof(Button))]
public class S_ButtonController : MonoBehaviour
{
    public ButtonType buttonType;
    Button uiButton;

    private void Start()
    {
        uiButton = GetComponent<Button>();
        uiButton.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        switch (buttonType)
        {
            case ButtonType.Start_Game:
                S_Actions.OpenGame(); break;
            case ButtonType.Open_Options:
                S_Actions.OpenOptions(); break;
            case ButtonType.Open_Credits:
                S_Actions.OpenCredits(); break;
            case ButtonType.Quit_Game:
                Application.Quit(); break;
            case ButtonType.Resume_Game:
                S_Actions.OpenGame(); break;
            case ButtonType.Open_MainMenu:
                S_Actions.OpenMainMenu(); break;
            case ButtonType.Open_Programmer:
                Application.OpenURL("https://github.com/ArthurSegato"); break;
            case ButtonType.Open_Sfx:
                Application.OpenURL("https://www.instagram.com/lilorecording/"); break;
            case ButtonType.Open_Font:
                Application.OpenURL("https://fonts.google.com/specimen/Roboto"); break;
            case ButtonType.Open_MoralSupport:
                Application.OpenURL("https://www.instagram.com/dr.ramon.ferraz/"); break;
        }
    }
}
