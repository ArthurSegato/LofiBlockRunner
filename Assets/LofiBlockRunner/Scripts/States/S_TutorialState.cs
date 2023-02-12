/// <summary>  
/// Title Screen state, handles player input, camera and  ui
/// </summary>
public class S_TutorialState : S_GameBaseState
{
    public override void EnterState(S_StateMachine gameState)
    {
        S_Actions.EnablePlayerInput();
        S_Actions.EnablePlayerCamera();
        S_Actions.EnablePlayerTutorial();
        S_Actions.EnableTutorialUI();
    }
    public override void LeaveState(S_StateMachine gameState)
    {
        S_Actions.DisableTutorialUI();
        S_Actions.DisablePlayerInput();
        S_Actions.DisablePlayerCamera();
        S_Actions.DisablePlayerTutorial();
    }
}
