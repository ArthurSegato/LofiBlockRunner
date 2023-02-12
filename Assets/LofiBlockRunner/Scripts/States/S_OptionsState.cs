using UnityEngine;
/// <summary>  
/// Options state, handles time freeze, options camera and ui
/// </summary>
public class S_OptionsState : S_GameBaseState
{
    public override void EnterState(S_StateMachine gameState)
    {
        S_Actions.EnableOptionsCamera();
        S_Actions.EnableOptionsUI();
        Time.timeScale = 0f;
    }

    public override void LeaveState(S_StateMachine gameState)
    {
        S_Actions.DisableOptionsCamera();
        S_Actions.DisableOptionsUI();
        Time.timeScale = 1.0f;
    }
}
