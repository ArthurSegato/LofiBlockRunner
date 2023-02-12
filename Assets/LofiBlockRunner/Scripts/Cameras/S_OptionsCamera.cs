using UnityEngine;

/// <summary>  
/// Class responsible for managing the options ui camera
/// </summary>
public class S_OptionsCamera : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnableOptionsCamera += () => this.gameObject.SetActive(true);
        S_Actions.DisableOptionsCamera += () => this.gameObject.SetActive(false);
    }
}
