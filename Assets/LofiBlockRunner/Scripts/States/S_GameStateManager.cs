using UnityEngine;

public class S_GameStateManager : MonoBehaviour
{
    S_GameBaseState currentState;

    public S_IntroState introState = new S_IntroState();
    public S_TitleScreenState titleScreenState = new S_TitleScreenState();
    public S_OptionsState optionsState = new S_OptionsState();
    public S_CreditsState creditsState = new S_CreditsState();
    public S_PlayingState playingState = new S_PlayingState();
    public S_EndGameState endGameState = new S_EndGameState();
    public S_TutorialState tutorialState = new S_TutorialState();
    public S_PauseState pauseState = new S_PauseState();

    private void Start()
    {
        currentState = titleScreenState;

        currentState.EnterState(this);
    }

    public void SwitchState(S_GameBaseState gameState)
    {
        currentState.LeaveState(this);
        currentState = gameState;
        gameState.EnterState(this);
    }

    private void OnEnable()
    {
        S_Actions.OpenTitleScreenMenu += () => SwitchState(titleScreenState);
        S_Actions.OpenOptionsMenu += () => SwitchState(optionsState);
        S_Actions.OpenCreditsMenu += () => SwitchState(creditsState);
        S_Actions.StartGame += () => SwitchState(playingState);
        S_Actions.EndGame+= () => SwitchState(endGameState);
        S_Actions.StartTutorial += () => SwitchState(tutorialState);
        S_Actions.PauseGame += () => SwitchState(pauseState);
    }
}
