using UnityEngine;

public class S_CreditsState : S_GameBaseState
{
    public override void EnterState(S_GameStateManager gameState)
    {
        S_Actions.EnableCreditsCamera();
        S_Actions.EnableCreditsUI();
    }

    public override void LeaveState(S_GameStateManager gameState)
    {
        S_Actions.DisableCreditsCamera();
        S_Actions.DisableCreditsUI();
    }
}
