using UnityEngine;

/// <summary>  
/// Handle obstacle destruction when colliding with barrier at the end of plataform
/// </summary>
public class S_ObstacleCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collided)
    {
        if (collided.transform.CompareTag("ObstacleBarrier")) Destroy(transform.parent.gameObject);
    }
}
