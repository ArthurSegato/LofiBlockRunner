using UnityEngine;
/// <summary>  
/// Options state, handles time freeze, options camera and ui
/// </summary>
public class S_OptionsState : S_GameBaseState
{
    public override void EnterState(S_StateMachine gameState)
    {
        S_Actions.EnableOptionsCamera();
        S_Actions.OpenOptionsUI();
        Time.timeScale = 0f;
    }

    public override void LeaveState(S_StateMachine gameState)
    {
        Time.timeScale = 1.0f;
    }
}
