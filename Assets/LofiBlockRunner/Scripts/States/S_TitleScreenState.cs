/// <summary>  
/// Title Screen state, handles player input, camera and  ui
/// </summary>
/// farofa
public class S_TitleScreenState : S_GameBaseState
{
    private bool hasObstaclesSpawned = false;
    private void Awake()
    {
        S_Actions.ObstacleSpawnedFlag += () => hasObstaclesSpawned = true;
        S_Actions.ObstacleDestroyedFlag += () => hasObstaclesSpawned = false;
    }
    public override void EnterState(S_StateMachine gameState)
    {
        S_Actions.EnableTitleScreenCamera();
        S_Actions.EnableTitleScreenUI();
        S_Actions.ResetPlayer();
        if (hasObstaclesSpawned) S_Actions.DestroyObstacles();
    }
    public override void LeaveState(S_StateMachine gameState)
    {
        S_Actions.DisableTitleScreenCamera();
        S_Actions.DisableTitleScreenUI();
    }
}
