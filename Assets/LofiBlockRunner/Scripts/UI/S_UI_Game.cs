using UnityEngine;
using UnityEngine.UIElements;

/// <summary>  
/// Class handling the game UI
/// </summary>
public class S_UI_Game : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnableGameUI += () => this.gameObject.SetActive(true);
        S_Actions.DisableGameUI += () => this.gameObject.SetActive(false);
    }
    private void OnEnable()
    {
        // Get the UI DOM
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        // Get all texts
        Label textScore = root.Q<Label>("score");

        // Change text value
        textScore.text = "0";
    }
}
