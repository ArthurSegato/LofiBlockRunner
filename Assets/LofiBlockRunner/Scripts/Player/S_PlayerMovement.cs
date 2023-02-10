using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>  
/// Class responsible for the player`s movement, has 2 functions,
/// the first one "Fixed Update" updates the player current position
/// the second on "OnMove" listen for input data, aka, keys pressed
/// </summary>
public class S_PlayerMovement : MonoBehaviour
{
    #region Variables
    [Tooltip("Player RigidBody.")]
    [SerializeField] private Rigidbody _rb;

    [Header("Movement")]
    [Tooltip("Speed of the lateral movement of the block.")]
    [SerializeField] private float _speed = 500f;

    private Vector3 _movement;
    #endregion

    #region Listeners
    private void Awake()
    {
        S_Actions.DisablePlayerInput += DisablePlayerMovement;
        S_Actions.EnablePlayerInput += EnablePlayerMovement;
    }

    #endregion

    #region Functions
    // Receives input from player
    private void OnMove(InputValue value) => _movement = value.Get<Vector2>();

    private void OnPause() => S_Actions.PauseGame(); 

    private void OnConfirm() => S_Actions.StartGame();

    // Update position based on player input
    private void FixedUpdate() => _rb.AddForce(_speed * _movement * Time.deltaTime);

    // Stop the player movement after death
    private void DisablePlayerMovement() => this.enabled = false;

    private void EnablePlayerMovement() => this.enabled = true;
    #endregion
}
