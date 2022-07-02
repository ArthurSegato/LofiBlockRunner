using UnityEngine;

public class GameBaseState : MonoBehaviour
{
    public abstract void EnterState(GameStateManager gameState);

    public abstract void UpdateState(GameStateManager gameState);
}
