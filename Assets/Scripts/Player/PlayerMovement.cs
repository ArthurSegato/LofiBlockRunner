using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    private InputSystem inputSystem;
    public Rigidbody playerRigidbody;
    public float speed = 0f;
    public float speedBoost = 0f;
    public float sidewaysForce = 0f;
    public float sidewaysForceBoost = 0f;
    public float checkpointDistance = 0f;
    public float checkpoint = 0f;
    public float border = 0f;

	private void Awake()
	{
        inputSystem = new InputSystem();
        checkpoint = checkpointDistance;

    }
	private void OnEnable()
	{
        inputSystem.Enable();
	}
	private void OnDisable()
	{
        inputSystem.Disable();
	}
	void FixedUpdate()
    {
        //Movimenta o personagem para a frente.
        playerRigidbody.AddForce(0, 0, speed * Time.deltaTime);

        //Checa se ele tentou passar da barreira, e se tentou empurra ele de volta para a posição anterior.
        if (transform.position.x >= border)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -border, border), transform.position.y, transform.position.z);
            playerRigidbody.AddForce(-5000f * Time.deltaTime, 0, 0);

        }
        if (transform.position.x <= -border)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -border, border), transform.position.y, transform.position.z);
            playerRigidbody.AddForce(5000f * Time.deltaTime, 0, 0);
        }
        //Checa se as teclas foram pressionadas, se forem, então adiciona a força no personagem.
        else
		{
            if (inputSystem.Player.Movement.ReadValue<float>() > 0)
            {
                playerRigidbody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (inputSystem.Player.Movement.ReadValue<float>() < 0)
            {
                playerRigidbody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }
        
        // Adiciona x de velocidade extra no jogador a cada y metros, o mesmo para o movimento lateral
        if(transform.position.z > checkpoint)
		{
            speed += speedBoost;
            sidewaysForce += sidewaysForceBoost;
            checkpoint += checkpointDistance;
		}
    }
}
