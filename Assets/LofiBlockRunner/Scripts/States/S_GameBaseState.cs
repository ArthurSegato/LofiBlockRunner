using UnityEngine;

public abstract class S_GameBaseState
{
    public abstract void EnterState(S_GameStateManager gameState);

    public abstract void LeaveState(S_GameStateManager gameState);
}
