using UnityEngine;

public class CameraShakeController : MonoBehaviour
{

    private float shakeTimeDuration;
	private float shakeFadeTime;
	private float shakeRotation;
	
	public float shakeDuration = 0f;
	public float shakePower = 0f;
	public float rotationMultiplier = 0f;

	
	private void LateUpdate()
	{
		if (shakeTimeDuration > 0)
		{
			shakeTimeDuration -= Time.deltaTime;

			float xAmount = Random.Range(-5f, 5f) * shakePower;
			float yAmount = Random.Range(-5f, 5f) * shakePower;

			transform.position += new Vector3(xAmount, yAmount, 0f);

			shakePower = Mathf.MoveTowards(shakePower, 0f, shakeFadeTime * Time.deltaTime);

			shakeRotation = Mathf.MoveTowards(shakeRotation, 0f, (shakeFadeTime * rotationMultiplier) * Time.deltaTime);
		}
		transform.rotation = Quaternion.Euler(0f, 0f, shakeRotation * Random.Range(-2f, 2f));
	}
	public void StartShake()
	{
        shakeTimeDuration = shakeDuration;
        
		shakeFadeTime = shakePower / shakeDuration;

		shakeRotation = shakePower * rotationMultiplier;
	}
}
