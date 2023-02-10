using UnityEngine;

/// <summary>  
/// Class responsible for handling obstacles collision,
/// When colliding with the barrier at the end of the map, the obstacle is destroyed from memory
/// </summary>
public class S_ObstacleCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collided)
    {
        if (collided.transform.CompareTag("ObstacleBarrier")) Destroy(transform.parent.gameObject);
    }
}
