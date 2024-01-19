using UnityEngine;

/// <summary>  
/// Handles player collision.
/// </summary>
public class S_PlayerCollision : MonoBehaviour
{
    #region Variables
    private bool _isColliderEnabled = true;
    #endregion

    #region Methods
    private void Awake()
    {
        S_Actions.Player_Disable_Collision += () => _isColliderEnabled = false;
        S_Actions.Player_Enable_Collision += () => _isColliderEnabled = true;
    }
    private void OnDestroy()
    {
        S_Actions.Player_Disable_Collision -= () => _isColliderEnabled = false;
        S_Actions.Player_Enable_Collision -= () => _isColliderEnabled = true;
    }
    // Check collision and flag
    void OnCollisionEnter(Collision collided)
    {
        if (_isColliderEnabled && collided.transform.CompareTag("Obstacle")) S_Actions.State_GameOver();
    }
    #endregion
}
