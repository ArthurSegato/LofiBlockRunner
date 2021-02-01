using UnityEngine;

public class TargetFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offSet;
    private Vector3 newPos;

    //Define os eixos X e Y como a posição inicial do chao
	private void Start()
	{
        newPos[0] = transform.position.x;
        newPos[1] = transform.position.y;
    }
    
    // Pega a posição do jogador no eixo z e passa pro chão.
	void Update()
    {
        newPos[2] = target.transform.position.z + offSet.z;
        transform.position = newPos;
    }
}
