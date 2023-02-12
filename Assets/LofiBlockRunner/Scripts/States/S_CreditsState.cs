/// <summary>  
/// Credits state, handles credits camera and ui
/// </summary>
public class S_CreditsState : S_GameBaseState
{
    public override void EnterState(S_StateMachine gameState)
    {
        S_Actions.EnableCreditsCamera();
        S_Actions.EnableCreditsUI();
    }

    public override void LeaveState(S_StateMachine gameState)
    {
        S_Actions.DisableCreditsCamera();
        S_Actions.DisableCreditsUI();
    }
}
