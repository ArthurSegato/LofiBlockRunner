using UnityEngine;

public class FollowObject : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;

    void Update()
    {
        //Define a posição do objeto atual como a posição do alvo que ele está seguindo
        // + uma distancia extra
        transform.position = target.position + offset;
    }
}
