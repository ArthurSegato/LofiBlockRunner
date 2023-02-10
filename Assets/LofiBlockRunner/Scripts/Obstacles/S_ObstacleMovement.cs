using UnityEngine;

/// <summary>  
/// Class responsible for the obstacles movement.
/// </summary>
public class S_ObstacleMovement : MonoBehaviour
{
    #region Variables
    [Tooltip("Obstacle RigidBody.")]
    [SerializeField] private Rigidbody _rb;

    [Header("Movement")]
    [Tooltip("Speed of the obstacle.")]
    [SerializeField] private float _speed = 1000f;
    #endregion

    #region Functions
    // Move obstacles
    private void FixedUpdate() => _rb.AddForce(_speed * Vector3.back * Time.deltaTime);
    #endregion
}
