using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    //Destroe o objeto ao sair da camera
    //FUNCIONOU PORRA!!!!!!!!
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
	private void OnCollisionExit(Collision collision)
	{
        if (collision.collider.tag == "Ground")
        {
            //Destroe o objeto que não estiver tocando no chão
            Destroy(gameObject);
        }
    }
}
