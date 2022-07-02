using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    // Estado Atual
    GameBaseState currentState;
    // Estados Existentes
    IntroState IntroState = new IntroState();
    MainMenuState MainMenuState = new MainMenuState();
    AboutState AboutState = new AboutState();
    SettingsState SettingsState = new SettingsState();
    PlayingState PlayingState = new PlayingState();

    void Start()
    {
        // Estado inicial para a máquina de estados
        currentState = IntroState;
        // "this" é uma referencia ao contexto 
        currentState.EnterState(this);
    }

}
