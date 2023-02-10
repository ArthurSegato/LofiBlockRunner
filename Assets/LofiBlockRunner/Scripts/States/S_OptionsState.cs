public class S_OptionsState : S_GameBaseState
{
    public override void EnterState(S_GameStateManager gameState)
    {
        S_Actions.EnableOptionsCamera();
        S_Actions.EnableOptionsUI();
    }

    public override void LeaveState(S_GameStateManager gameState)
    {
        S_Actions.DisableOptionsCamera();
        S_Actions.DisableOptionsUI();
    }
}
