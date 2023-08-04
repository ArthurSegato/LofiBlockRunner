/// <summary>  
/// Playing state, handles obstacles spawning, player collision, camera and  ui
/// </summary>
public class S_PlayingState : S_GameBaseState
{
    public override void EnterState(S_StateMachine gameState)
    {
        S_Actions.EnableObstacleManager();
        S_Actions.OpenGameUI();
        S_Actions.EnableGameCamera();
        S_Actions.EnablePlayerInput();
        S_Actions.EnablePlayerPause();
        
    }
    public override void LeaveState(S_StateMachine gameState)
    {
        S_Actions.DisableObstacleManager();
        S_Actions.DisablePlayerCollision();
        S_Actions.DisablePlayerInput();
        S_Actions.DisablePlayerPause();
    }
}
