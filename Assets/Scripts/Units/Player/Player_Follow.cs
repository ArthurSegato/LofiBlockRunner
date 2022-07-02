using UnityEngine;

public class Player_Follow : MonoBehaviour
{
    public string target_Tag;
    public Vector3 offSet;

    private Vector3 newPos;
    private Transform target;

    // Define os eixos X e Y como a posição inicial do chao
    // Define que o alvo vai ser o objeto com a tag definida no edito (nesse caso o jogador)
    private void Start()
	{
        target = GameObject.FindWithTag(target_Tag).transform;
        newPos[0] = transform.position.x;
        newPos[1] = transform.position.y;
    }
    
    // Pega a posição do alvo no eixo z e passa pro chão.
	void Update()
    {
        newPos[2] = target.transform.position.z + offSet.z;
        transform.position = newPos;
    }
}
