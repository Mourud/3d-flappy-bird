using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float forwardSpeed;
    public float forwardForce;
    public float jumpForce;
    public float latteralForce;

    public Rigidbody rb;


    void FixedUpdate()
    {
        //Vector3 forwardVelocity = new Vector3(0, 0, forwardSpeed);

        if (rb.velocity.z <= forwardSpeed)
        {
            rb.AddForce(0,0,forwardForce*Time.deltaTime);
        }

        //rb.MovePosition(transform.position + forwardVelocity*Time.deltaTime);


        // Jump mechanic. May need tweaking
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0,ForceMode.Impulse);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-latteralForce, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(latteralForce, 0, 0);
        }
    }
}
