using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        //Atualiza o placar com a posição atual do jogador no eixo z
        scoreText.text = player.position.z.ToString("0");
    }
}
