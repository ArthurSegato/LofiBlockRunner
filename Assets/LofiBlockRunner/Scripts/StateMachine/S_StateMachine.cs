using UnityEngine;
/// <summary>  
/// State Machine, handles all states changes
/// </summary>
public class S_StateMachine : MonoBehaviour
{
    #region Variables
    private S_StateBase _currentState;

    public S_StateIntro stateIntro = new S_StateIntro();
    public S_StateMainMenu stateMainMenu = new S_StateMainMenu();
    public S_StateSettings stateSettings = new S_StateSettings();
    public S_StateCredits stateCredits = new S_StateCredits();
    public S_StateGame stateGame = new S_StateGame();
    public S_StateGameOver stateGameOver = new S_StateGameOver();
    public S_StateTutorial stateTutorial = new S_StateTutorial();
    public S_StatePause statePause = new S_StatePause();
    #endregion

    #region Methods
    // Register functions to Actions
    private void Awake()
    {
        S_Actions.State_Tutorial += () => SwitchState(stateTutorial);
        S_Actions.State_MainMenu += () => SwitchState(stateMainMenu);
        S_Actions.State_Settings += () => SwitchState(stateSettings);
        S_Actions.State_Credits += () => SwitchState(stateCredits);
        S_Actions.State_Game += () => SwitchState(stateGame);
        S_Actions.State_Pause += () => SwitchState(statePause);
        S_Actions.State_GameOver += () => SwitchState(stateGameOver);
    }

    private void OnDestroy()
    {
        S_Actions.State_Tutorial -= () => SwitchState(stateTutorial);
        S_Actions.State_MainMenu -= () => SwitchState(stateMainMenu);
        S_Actions.State_Settings -= () => SwitchState(stateSettings);
        S_Actions.State_Credits -= () => SwitchState(stateCredits);
        S_Actions.State_Game -= () => SwitchState(stateGame);
        S_Actions.State_Pause -= () => SwitchState(statePause);
        S_Actions.State_GameOver -= () => SwitchState(stateGameOver);
    }

    private void Start()
    {
        // Set initial state
        _currentState = stateMainMenu;
        // Enter the current
        _currentState.EnterState(this);
    }

    // Switch between states
    private void SwitchState(S_StateBase newState)
    {
        // Leave old state
        _currentState.LeaveState(this);
        // Set new state as current
        _currentState = newState;
        // Enter new state
        newState.EnterState(this);
    }
    #endregion
}
