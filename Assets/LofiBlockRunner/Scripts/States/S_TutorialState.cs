
public class S_TutorialState : S_GameBaseState
{
    public override void EnterState(S_GameStateManager gameState)
    {
        S_Actions.EnablePlayerInput();
        S_Actions.EnablePlayerCamera();
        S_Actions.EnableTutorialUI();
    }
    public override void LeaveState(S_GameStateManager gameState)
    {
        S_Actions.DisableTutorialUI();
    }
}
