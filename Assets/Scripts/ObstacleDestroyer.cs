using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
    //Destroe o objeto ao sair da camera
    //FUNCIONOU PORRA!!!!!!!!
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
