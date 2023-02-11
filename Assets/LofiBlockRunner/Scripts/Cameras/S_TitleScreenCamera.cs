using UnityEngine;

/// <summary>  
/// Class responsible for managing the title screen ui camera
/// </summary>
public class S_TitleScreenCamera : MonoBehaviour
{
    // Register methods to the Action
    private void Awake()
    {
        S_Actions.EnableTitleScreenCamera += EnableCamera;
        S_Actions.DisableTitleScreenCamera += DisableCamera;
    }

    private void EnableCamera() => this.gameObject.SetActive(true);

    private void DisableCamera() => this.gameObject.SetActive(false);
}
