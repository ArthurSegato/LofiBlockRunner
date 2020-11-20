using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 0f;
    public float sidewaysForce = 0f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);
        if (Input.GetKey("d"))
		{
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
