using UnityEngine;

/// <summary>  
/// Class responsible for the reseting the player.
/// </summary>
public class S_PlayerReset : MonoBehaviour
{
    private void Awake() => S_Actions.ResetPlayer += ResetPlayer;

    private void ResetPlayer()
    {
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
    }
}
