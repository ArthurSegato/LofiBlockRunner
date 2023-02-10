using UnityEngine;
using UnityEngine.UIElements;

public class S_UI_Game : MonoBehaviour
{
    private void Awake()
    {
        S_Actions.EnableGameUI += EnableUI;
        S_Actions.DisableGameUI += DisableUI;
    }
    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Label textScore = root.Q<Label>("score");

        textScore.text = "Pegar esse texto do input";
    }
    private void EnableUI() => this.gameObject.SetActive(true);

    private void DisableUI() => this.gameObject.SetActive(false);
}
