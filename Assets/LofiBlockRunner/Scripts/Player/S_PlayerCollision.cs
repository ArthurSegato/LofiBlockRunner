using UnityEngine;

/// <summary>  
/// Class responsible for the handling player collision.
/// </summary>
public class S_PlayerCollision : MonoBehaviour
{
    #region Variables
    private bool _isColliderEnabled = true;
    #endregion

    #region Functions
    private void Awake()
    {
        S_Actions.DisablePlayerCollision += () => _isColliderEnabled = false;
        S_Actions.EnablePlayerCollision += () => _isColliderEnabled = true;
    }
    // Check collision and flag
    void OnCollisionEnter(Collision collided)
    {
        if (collided.transform.CompareTag("Obstacle") && _isColliderEnabled) S_Actions.EndGame();
    }
    #endregion
}
