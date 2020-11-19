using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //Define a posição da camera como a posição do jogador + distancia estabelecida
        transform.position = player.position + offset;
    }
}
