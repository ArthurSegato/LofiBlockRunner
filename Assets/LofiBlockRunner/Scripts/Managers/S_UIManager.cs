using UnityEngine;

/// <summary>  
/// Class responsible for deactivating all UI Documents, and then enable a chosen one
/// </summary>
public class S_UIManager : MonoBehaviour
{
    #region Variables
    [Header("UIs Settings")]
    [Tooltip("List with all UIs.")]
    [SerializeField] private GameObject[] _uiList;
    [SerializeField] private GameObject _startUI;
    #endregion

    #region Functions
    private void Start()
    {
        // Disable all UI Documents
        foreach (GameObject ui in _uiList)
        {
            if (ui == _startUI) ui.SetActive(true);
            else ui.SetActive(false);
        }
    }
    #endregion
}
