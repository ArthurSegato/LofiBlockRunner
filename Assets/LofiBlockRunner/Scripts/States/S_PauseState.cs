using UnityEngine;
/// <summary>  
/// Pause state, handles time freeze, and pause ui
/// </summary>
public class S_PauseState : S_GameBaseState
{
    public override void EnterState(S_StateMachine gameState)
    {
        S_Actions.EnableGameCamera();
        S_Actions.OpenPauseUI();
        Time.timeScale = 0f;
    }

    public override void LeaveState(S_StateMachine gameState)
    {
        Time.timeScale = 1.0f;
    }
}
