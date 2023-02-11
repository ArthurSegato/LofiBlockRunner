public class S_PlayingState : S_GameBaseState
{
    public override void EnterState(S_GameStateManager gameState)
    {
        S_Actions.EnableObstacleManager();
        S_Actions.EnableGameUI();
    }
    public override void LeaveState(S_GameStateManager gameState)
    {
        S_Actions.EnableObstacleManager();
        S_Actions.DisableGameUI();
        S_Actions.DisablePlayerCollision();
    }
}
