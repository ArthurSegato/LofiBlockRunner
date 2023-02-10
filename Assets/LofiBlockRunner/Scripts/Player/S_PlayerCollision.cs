using UnityEngine;

public class S_PlayerCollision : MonoBehaviour
{
    #region Listeners
    private void Awake()
    {
        S_Actions.DisablePlayerCollision += DisablePlayerCollision;
        S_Actions.EnablePlayerCollision += EnablePlayerCollision;
    }

    #endregion

    void OnCollisionEnter(Collision collided)
    {
        if (collided.transform.CompareTag("Obstacle")) S_Actions.EndGame();
    }

    // Stop the player movement after death
    private void DisablePlayerCollision() => this.enabled = false;

    private void EnablePlayerCollision() => this.enabled = true;
}
