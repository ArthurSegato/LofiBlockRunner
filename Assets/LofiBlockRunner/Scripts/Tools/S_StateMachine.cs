using UnityEngine;
/// <summary>  
/// State Machine, handles all states changes
/// </summary>
public class S_StateMachine : MonoBehaviour
{
    #region Variables
    private S_GameBaseState _currentState;

    public S_IntroState introState = new S_IntroState();
    public S_MainMenuState mainMenuState = new S_MainMenuState();
    public S_OptionsState optionsState = new S_OptionsState();
    public S_CreditsState creditsState = new S_CreditsState();
    public S_PlayingState playingState = new S_PlayingState();
    public S_EndGameState endGameState = new S_EndGameState();
    public S_TutorialState tutorialState = new S_TutorialState();
    public S_PauseState pauseState = new S_PauseState();
    #endregion

    #region Functions
    // Register functions to Actions
    private void Awake()
    {
        S_Actions.OpenMainMenu += () => SwitchState(mainMenuState);
        S_Actions.OpenOptions += () => SwitchState(optionsState);
        S_Actions.OpenCredits += () => SwitchState(creditsState);
        S_Actions.OpenTutorial += () => SwitchState(tutorialState);
        S_Actions.OpenGame += () => SwitchState(playingState);
        S_Actions.EndGame += () => SwitchState(endGameState);
        S_Actions.PauseGame += () => SwitchState(pauseState);
    }
    private void Start()
    {
        // Set current state
        _currentState = mainMenuState;
        // Enter the current
        _currentState.EnterState(this);
    }

    // Switch between 2 states
    public void SwitchState(S_GameBaseState gameState)
    {
        // Execute old state
        _currentState.LeaveState(this);
        // Change states
        _currentState = gameState;
        // Enter next state
        gameState.EnterState(this);
    }
    #endregion
}
