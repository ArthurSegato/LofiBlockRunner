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
        S_Actions.DisablePlayerCollision += DisablePlayerCollision;
        S_Actions.EnablePlayerCollision += EnablePlayerCollision;
    }
    // Check collision and flag
    void OnCollisionEnter(Collision collided)
    {
        if (collided.transform.CompareTag("Obstacle") || _isColliderEnabled) S_Actions.EndGame();
    }

    // Disable colision detection, so the fragments of the broken mesh dont trigger collisions
    private void DisablePlayerCollision() => _isColliderEnabled = false;

    private void EnablePlayerCollision() => _isColliderEnabled = true;
    #endregion
}
