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
    [Tooltip("UI wich shoud be keep active.")]
    [SerializeField] private GameObject _startUi;
    #endregion

    #region Functions
    private void Start()
    {
        // Disable all UI Documents except the start one
        foreach(GameObject ui in _uiList)
        {
            if(ui == _startUi) ui.SetActive(true);
            else ui.SetActive(false);
        }
    }
    #endregion
}
