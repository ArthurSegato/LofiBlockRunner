using UnityEngine;

/// <summary>  
/// Class responsible for managing the player camera
/// </summary>
public class S_PlayerCamera : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnablePlayerCamera += () => this.gameObject.SetActive(true);
        S_Actions.DisablePlayerCamera += () => this.gameObject.SetActive(false);
    }
}
