using UnityEngine;

/// <summary>  
/// Set intial states of many objects
/// </summary>
public class S_ManagerGame : MonoBehaviour
{
    private void Start()
    {
        S_Actions.Player_Disable_Input();
        S_Actions.Obstacle_Disable_Manager();
    }
}
