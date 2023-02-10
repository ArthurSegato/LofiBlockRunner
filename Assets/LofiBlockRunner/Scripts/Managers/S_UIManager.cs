using UnityEngine;

public class S_UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _uiList;
    [SerializeField]
    private GameObject _startUi;

    private void Awake()
    {
        // Disable all UI Documents except the first one
        foreach(GameObject ui in _uiList)
        {
            if(ui == _startUi) ui.SetActive(true);
            else ui.SetActive(false);
        }
    }
}
