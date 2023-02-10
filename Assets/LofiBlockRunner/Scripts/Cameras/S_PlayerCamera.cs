using UnityEngine;

public class S_PlayerCamera : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnablePlayerCamera += EnableCamera;
        S_Actions.DisablePlayerCamera += DisableCamera;
    }

    private void EnableCamera() => this.gameObject.SetActive(true);

    private void DisableCamera() => this.gameObject.SetActive(false);
}
