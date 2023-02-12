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
    private bool _isPaused = false;
    private bool _isTutorial = false;

    private Vector3 _movement;
    #endregion

    #region Functions
    private void Awake()
    {
        S_Actions.EnablePlayerInput += () => this.enabled = true;
        S_Actions.DisablePlayerInput += () => this.enabled = false;
        S_Actions.EnablePlayerPause += () => _isPaused = true;
        S_Actions.DisablePlayerPause += () => _isPaused = false;
        S_Actions.EnablePlayerTutorial += () => _isTutorial = true;
        S_Actions.DisablePlayerTutorial += () => _isTutorial = false;
    }

    // Receives input from player
    private void OnMove(InputValue value) => _movement = value.Get<Vector2>();

    private void OnPause()
    {
        if (_isPaused == true) S_Actions.PauseGame();
    }

    private void OnConfirm()
    {
        if(_isTutorial == true) S_Actions.OpenGame();
    }

    // Update position based on player input
    private void FixedUpdate() => _rb.AddForce(_speed * _movement * Time.deltaTime);
    #endregion
}
