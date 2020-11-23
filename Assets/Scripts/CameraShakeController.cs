using UnityEngine;

public class CameraShakeController : MonoBehaviour
{

    private float shakeTimeDuration;
    private float shakePower;
	private float shakeFadeTime;
	private float shakeRotation;

	public float rotationMultiplier = 15f;

	//Só sei que balança a camera, o tutorial mandou eu fiz :v
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
	public void StartShake(float lenght, float power)
	{
        shakeTimeDuration = lenght;
        shakePower = power;

		shakeFadeTime = power / lenght;

		shakeRotation = power * rotationMultiplier;
	}
}
