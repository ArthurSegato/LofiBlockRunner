using UnityEngine;

/// <summary>  
/// Class responsible for changing meshs
/// </summary>
public class S_MeshChanger : MonoBehaviour
{
    #region Variables
    [Header("Mesh Selection")]
    [Tooltip("Original Mesh")]
    [SerializeField] private GameObject _originalMesh;
    [Tooltip("Broken Mesh")]
    [SerializeField] private GameObject _brokenMesh;
    #endregion

    #region Listeners
    private void OnEnable()
    {
        S_Actions.EndGame += BrakeMesh;
        S_Actions.ResetPlayer += FixMesh;
    }
    #endregion

    #region Functions
    private void BrakeMesh()
    {
        _originalMesh.SetActive(false);
        _brokenMesh.SetActive(true);
    }

    private void FixMesh()
    {
        _originalMesh.SetActive(true);
        _brokenMesh.SetActive(false);
    }
    #endregion
}
