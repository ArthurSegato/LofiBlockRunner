using UnityEngine;
/// <summary>  
/// Settings state, handles time freeze, options camera and ui
/// </summary>
public class S_SettingsState : S_GameBaseState
{
    public override void EnterState(S_StateMachine gameState)
    {
        S_Actions.EnableSettingsCamera();
        S_Actions.OpenSettingsUI();
        Time.timeScale = 0f;
    }

    public override void LeaveState(S_StateMachine gameState)
    {
        Time.timeScale = 1.0f;
    }
}
