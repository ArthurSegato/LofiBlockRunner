using UnityEngine;

/// <summary>  
/// Class responsible for changing the player mesh on death
/// </summary>
public class S_PlayerMeshChanger : MonoBehaviour
{
    #region Variables
    [SerializeField] private GameObject _playerMesh;
    [SerializeField] private GameObject _playerBrokenMesh;
    #endregion

    #region Listeners
    private void OnEnable()
    {
        S_Actions.EndGame += BrakePlayerMesh;
        S_Actions.ResetPlayer += FixPlayerMesh;
    }
    #endregion

    #region Functions
    private void BrakePlayerMesh()
    {
        _playerMesh.SetActive(false);
        _playerBrokenMesh.SetActive(true);
    }

    private void FixPlayerMesh()
    {
        _playerMesh.SetActive(true);
        _playerBrokenMesh.SetActive(false);
    }
    #endregion
}
