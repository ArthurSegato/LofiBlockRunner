using UnityEngine;

public class S_CreditsCamera : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnableCreditsCamera += EnableCamera;
        S_Actions.DisableCreditsCamera += DisableCamera;
    }

    private void EnableCamera() => this.gameObject.SetActive(true);

    private void DisableCamera() => this.gameObject.SetActive(false);
}