using UnityEngine;

public class S_PauseState : S_GameBaseState
{
    public override void EnterState(S_GameStateManager gameState)
    {
        S_Actions.EnablePauseUI();

        Time.timeScale = 0f;
    }

    public override void LeaveState(S_GameStateManager gameState)
    {
        S_Actions.DisablePauseUI();

        Time.timeScale = 1.0f;
    }
}
