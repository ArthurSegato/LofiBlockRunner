using UnityEngine;

/// <summary>  
/// Class responsible for the obstacles movement.
/// </summary>
public class S_ObstacleMovement : MonoBehaviour
{
    #region Variables
    [Tooltip("Obstacle RigidBody.")]
    [SerializeField] private Rigidbody _rb;

    [Header("Movement Settings")]
    [Tooltip("Speed of the obstacle.")]
    [SerializeField] private float _speed = 1000f;

    private bool _isGameFinished = false;
    #endregion

    #region Functions
    // Register functions to end game action
    private void Awake()
    {
        S_Actions.EndGame += StopObstacles;
    }

    // Move obstacles
    private void FixedUpdate()
    {
        // Move the obstacle
        if (!_isGameFinished) _rb.AddForce(_speed * Vector3.back * Time.deltaTime);
        // If game has ended, then slow down the obstacle
        else _rb.velocity = _rb.velocity / 1.01f;
    }
    // Function to update the flag
    private void StopObstacles()
    {
        _isGameFinished = true;
    }
    #endregion
}
