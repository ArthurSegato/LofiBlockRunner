using UnityEngine;

public enum RotationDirection
{
    Right,
    Left
}

/// <summary>  
/// Class responsible for rotating the camera manager.
/// </summary>
public class S_CameraRotation : MonoBehaviour
{
    #region Variables
    [Header("Camera Settings")]
    [Tooltip("Direction in which the camera will rotate.")]
    [SerializeField] private RotationDirection _direction = RotationDirection.Right;
    private float _desiredDirection = 1f;
    [Tooltip("Speed of the camera rotation.")]
    [SerializeField] private float _speed = 0f;
    #endregion

    #region Methods
    private void Start() 
    {
        if(_direction == RotationDirection.Left) _desiredDirection = -1f;
    }
    private void Update() => transform.eulerAngles += new Vector3(0, _desiredDirection * _speed * Time.unscaledDeltaTime, 0);
    #endregion
}