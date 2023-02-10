using UnityEngine;

/// <summary>  
/// Class responsible for rotating the camera manager.
/// </summary>
public class S_CameraRotation : MonoBehaviour
{
    #region Variables
    [Header("Camera Settings")]
    [Tooltip("Direction in which the camera will rotate, positive to the right, negative to the left.")]
    [SerializeField] private float _direction = 0f;
    [Tooltip("Speed of the camera rotation.")]
    [SerializeField] private float _speed = 0f;
    #endregion

    #region Functions
    void Update() => transform.eulerAngles += new Vector3(0, _direction * _speed * Time.deltaTime, 0);
    #endregion
}