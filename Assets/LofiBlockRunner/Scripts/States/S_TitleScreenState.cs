using UnityEngine;

public class S_TitleScreenState : S_GameBaseState
{
    public override void EnterState(S_GameStateManager gameState)
    {
        S_Actions.DisableObstacleManager();
        S_Actions.DisablePlayerInput();
        S_Actions.EnableTitleScreenCamera();
        S_Actions.EnableTitleScreenUI();
    }
    public override void LeaveState(S_GameStateManager gameState)
    {
        S_Actions.DisableTitleScreenCamera();
        S_Actions.DisableTitleScreenUI();
    }
}
