using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public Transform originalPos = Transform.position;
    public Rigidbody rb;

    public float force = 2000f;
    public float hor_force = 500f;


    // Update is called once per frame
    void FixedUpdate()
    {



        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0,0, force * Time.deltaTime, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(hor_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-hor_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}