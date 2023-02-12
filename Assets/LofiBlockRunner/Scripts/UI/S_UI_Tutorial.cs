using UnityEngine;

/// <summary>  
/// Class handling the tutorial UI
/// </summary>
public class S_UI_Tutorial : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnableTutorialUI += () => this.gameObject.SetActive(true);
        S_Actions.DisableTutorialUI += () => this.gameObject.SetActive(false);
    }
}
