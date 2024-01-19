using UnityEngine;

/// <summary>  
/// Make a gameobject follow another
/// </summary>
public class S_Follow : MonoBehaviour
{
    #region Variables
    [Header("Follow Settings")]
    [Tooltip("Object that will be followed.")]
    [SerializeField] private GameObject _target;
    #endregion
    
    #region Methods
    private void LateUpdate() => transform.position = _target.transform.position;
    #endregion
}
