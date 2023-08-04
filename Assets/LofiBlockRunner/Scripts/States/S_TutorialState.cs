/// <summary>  
/// Title Screen state, handles player input, camera and  ui
/// </summary>
public class S_TutorialState : S_GameBaseState
{
    public override void EnterState(S_StateMachine gameState)
    {
        S_Actions.EnablePlayerInput();
        S_Actions.EnableGameCamera();
        S_Actions.EnablePlayerTutorial();
        S_Actions.OpenTutorialUI();
    }
    public override void LeaveState(S_StateMachine gameState)
    {
        S_Actions.DisablePlayerInput();
        S_Actions.DisablePlayerTutorial();
    }
}
