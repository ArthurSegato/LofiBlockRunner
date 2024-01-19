using UnityEngine;

/// <summary>  
/// Handle obstacles movement
/// </summary>
public class S_ObstacleMovement : MonoBehaviour
{
    #region Variables
    [Tooltip("Obstacle RigidBody.")]
    [SerializeField] private Rigidbody _rb;

    [Header("Movement Settings")]
    [Tooltip("Speed of the obstacle.")]
    [SerializeField] private float _speed = 1000f;

    [Tooltip("Speed in which the obstacle will slow down.")]
    [SerializeField] private float _stoppingSpeed = 1.02f;

    private bool _isGameFinished = false;
    #endregion

    #region Methods
    private void Awake() => S_Actions.Obstacle_Disable_Movement += () => _isGameFinished = true;
    private void OnDestroy() => S_Actions.Obstacle_Disable_Movement -= () => _isGameFinished = true;

    // Move obstacles
    private void FixedUpdate()
    {
        // If game has ended, then slow down the obstacle
        if (_isGameFinished) _rb.velocity = _rb.velocity / _stoppingSpeed;
        // If not, keep moving
        else _rb.AddForce(_speed * Vector3.back * Time.deltaTime);         
    }
    #endregion
}
