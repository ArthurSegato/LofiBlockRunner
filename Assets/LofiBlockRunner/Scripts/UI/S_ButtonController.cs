using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public enum ButtonType
{
    State_MainMenu,
    State_Game,
    State_Settings,
    State_Credits,
    Quit_Game,
    Visit_Programmer,
    Visit_Sfx,
    Visit_Font,
}

/// <summary>  
/// Handles button interactions like clicks, hover and etc
/// </summary>
[RequireComponent(typeof(Button))]
public class S_ButtonController : MonoBehaviour
{
    [SerializeField] private ButtonType _buttonType;

    Button uiButton;

    private void Start()
    {
        uiButton = GetComponent<Button>();
        uiButton.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        switch (_buttonType)
        {
            case ButtonType.State_MainMenu:
                S_Actions.State_MainMenu(); break;
            case ButtonType.State_Game:
                S_Actions.State_Game(); break;
            case ButtonType.State_Settings:
                S_Actions.State_Settings(); break;
            case ButtonType.State_Credits:
                S_Actions.State_Credits(); break;
            case ButtonType.Quit_Game:
                Application.Quit(); break;
            case ButtonType.Visit_Programmer:
                Application.OpenURL("https://github.com/ArthurSegato"); break;
            case ButtonType.Visit_Sfx:
                Application.OpenURL("https://www.instagram.com/carvalholilomusica/"); break;
            case ButtonType.Visit_Font:
                Application.OpenURL("https://fonts.google.com/specimen/Roboto"); break;
        }
    }
}
