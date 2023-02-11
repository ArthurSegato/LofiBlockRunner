using UnityEngine;

public class S_OptionsState : S_GameBaseState
{
    public override void EnterState(S_GameStateManager gameState)
    {
        S_Actions.EnableOptionsCamera();
        S_Actions.EnableOptionsUI();
        Time.timeScale = 0f;
    }

    public override void LeaveState(S_GameStateManager gameState)
    {
        S_Actions.DisableOptionsCamera();
        S_Actions.DisableOptionsUI();
    }
}
