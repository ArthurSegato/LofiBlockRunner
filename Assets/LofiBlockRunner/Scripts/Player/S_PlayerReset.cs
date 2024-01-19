using UnityEngine;

/// <summary>  
/// Handles player reset
/// </summary>
public class S_PlayerReset : MonoBehaviour
{
    private void Awake() => S_Actions.Player_Reset += ResetPlayer;
    private void OnDestroy() => S_Actions.Player_Reset -= ResetPlayer;

    private void ResetPlayer()
    {
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
    }
}
