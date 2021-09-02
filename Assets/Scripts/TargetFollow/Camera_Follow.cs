using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
	public string target_Tag;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

	private Transform target;
	private Vector3 velocity = Vector3.zero;

	// Define como alvo o objeto que tiver a tag escrita no editor (nesse caso o jogador)
	private void Start()
	{
		target = GameObject.FindWithTag(target_Tag).transform;
	}
	
	// Define a posição da camera como a posição do alvo de forma suave
	private void LateUpdate()
	{
		// Define a posição da camera como a posição do alvo + distancia
		Vector3 desiredPosition = target.position + offset;
		// Define a própria posição como a posição adquirida na linha anterior e aplica uma transição para deixar suave.
		transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);
		// Força a camera a olhar o alvo definido
		transform.LookAt(target);
	}
}
