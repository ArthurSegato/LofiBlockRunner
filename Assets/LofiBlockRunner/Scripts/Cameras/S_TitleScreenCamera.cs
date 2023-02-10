using UnityEngine;

public class S_TitleScreenCamera : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnableTitleScreenCamera += EnableCamera;
        S_Actions.DisableTitleScreenCamera += DisableCamera;
    }

    private void EnableCamera() => this.gameObject.SetActive(true);

    private void DisableCamera() => this.gameObject.SetActive(false);
}
