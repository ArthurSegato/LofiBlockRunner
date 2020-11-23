using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 0f;
    public float speedBoost = 0f;
    public float sidewaysForce = 0f;
    public float sidewaysForceBoost = 0f;
    public float checkpointDistance = 0f;
    public float border = 0f;
    
	void FixedUpdate()
    {
        //Movimenta o personagem para a frente.
        rb.AddForce(0, 0, speed * Time.deltaTime);

        //Checa se ele tentou passar da barreira, e se tentou empurra ele de volta para a posição anterior.
        if (transform.position.x >= border)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -border, border), transform.position.y, transform.position.z);
            rb.AddForce(-10000f * Time.deltaTime, 0, 0);

        }
        if (transform.position.x <= -border)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -border, border), transform.position.y, transform.position.z);
            rb.AddForce(10000f * Time.deltaTime, 0, 0);
        }
        //Checa se as teclas foram pressionadas, se forem, então adiciona a força no personagem.
        else
		{
            if (Input.GetKey("d"))
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("a"))
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }
        
        
        // Adiciona x de velocidade extra no jogador a cada y metros, o mesmo para o movimento lateral
        if(transform.position.z > checkpointDistance)
		{
            speed += speedBoost;
            sidewaysForce += sidewaysForceBoost;
            checkpointDistance += checkpointDistance;
		}
    }
}
