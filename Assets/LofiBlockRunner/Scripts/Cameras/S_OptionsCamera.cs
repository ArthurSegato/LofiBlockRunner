using UnityEngine;

/// <summary>  
/// Class responsible for managing the options ui camera
/// </summary>
public class S_OptionsCamera : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnableOptionsCamera += EnableCamera;
        S_Actions.DisableOptionsCamera += DisableCamera;
    }

    private void EnableCamera() => this.gameObject.SetActive(true);

    private void DisableCamera() => this.gameObject.SetActive(false);
}
