public class S_EndGameState : S_GameBaseState
{
    public override void EnterState(S_GameStateManager gameState)
    {
        S_Actions.DisableObstacleManager();
        S_Actions.DisablePlayerInput();
        S_Actions.EnableEndScreenUI();
        S_Actions.DisablePlayerCollision();
    }

    public override void LeaveState(S_GameStateManager gameState)
    {
        S_Actions.ResetPlayer();
        S_Actions.DisableEndScreenUI();
        S_Actions.EnablePlayerInput();
        S_Actions.EnablePlayerCollision();
    }
}
