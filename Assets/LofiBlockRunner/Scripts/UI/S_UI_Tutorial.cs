using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class S_UI_Tutorial : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnableTutorialUI += EnableUI;
        S_Actions.DisableTutorialUI += DisableUI;
    }
    private void EnableUI() => this.gameObject.SetActive(true);

    private void DisableUI() => this.gameObject.SetActive(false);
}
