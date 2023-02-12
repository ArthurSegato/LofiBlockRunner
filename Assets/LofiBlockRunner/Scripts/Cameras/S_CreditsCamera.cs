using UnityEngine;

/// <summary>  
/// Class responsible for managing the credits ui camera
/// </summary>
public class S_CreditsCamera : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnableCreditsCamera += () => this.gameObject.SetActive(true);
        S_Actions.DisableCreditsCamera += () => this.gameObject.SetActive(false);
    }
}
