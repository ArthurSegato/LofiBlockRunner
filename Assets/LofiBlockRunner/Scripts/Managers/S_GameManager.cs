using UnityEngine;

/// <summary>  
/// Prepare the game on start
/// </summary>
public class S_GameManager : MonoBehaviour
{
    private void Start()
    {
        S_Actions.DisablePlayerInput();
        S_Actions.DisableObstacleManager();
    }
}
