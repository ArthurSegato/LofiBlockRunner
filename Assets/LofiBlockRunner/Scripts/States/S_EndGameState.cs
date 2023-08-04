/// <summary>  
/// GameOver state, handles obstacles spawning, player input, camera and ui
/// </summary>
public class S_EndGameState : S_GameBaseState
{
    public override void EnterState(S_StateMachine gameState)
    {
        S_Actions.OpenEndScreenUI();
        S_Actions.EnableGameCamera();
        S_Actions.DisablePlayerInput();
        S_Actions.DisablePlayerCollision();
        S_Actions.DisableObstacleMovement();
        S_Actions.BrakePlayer();
        S_Actions.HiddeObstacles();
    }

    public override void LeaveState(S_StateMachine gameState)
    {
        S_Actions.ResetPlayer();
        S_Actions.EnablePlayerInput();
        S_Actions.EnablePlayerCollision();
        S_Actions.DestroyObstacles();
    }
}
