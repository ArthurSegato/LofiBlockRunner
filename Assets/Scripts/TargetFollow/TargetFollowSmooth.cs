using UnityEngine;

public class TargetFollowSmooth : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
	private Vector3 velocity = Vector3.zero;

	// A camera segue o jogador com um efeito suave
	private void LateUpdate()
	{
		Vector3 desiredPosition = target.position + offset;
		Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);
		transform.position = smoothedPosition;

		transform.LookAt(target);
	}
}
