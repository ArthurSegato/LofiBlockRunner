using UnityEngine;

/// <summary>  
/// Class responsible for managing the title screen ui camera
/// </summary>
public class S_TitleScreenCamera : MonoBehaviour
{
    // Register methods to the Action
    private void Awake()
    {
        S_Actions.EnableTitleScreenCamera += () => gameObject.SetActive(true);
        S_Actions.DisableTitleScreenCamera += () => gameObject.SetActive(false);
    }
}
