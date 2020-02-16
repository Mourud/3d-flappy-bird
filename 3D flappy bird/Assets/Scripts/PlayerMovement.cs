using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float forwardSpeed;
    public float jumpForce;
    public float fallMultiplier = 3.5f;
    public float lowJumpMultiplier = 2f;
    public float latteralForce;

    public Rigidbody rb;

    //void Update () 
    //{
    //    if (rb.velocity.y < 0) 
    //    {
    //        rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
    //    }
    //}

    void FixedUpdate()
    {
        Vector3 forwardVelocity = new Vector3(0, 0, forwardSpeed);
        rb.MovePosition(transform.position + forwardVelocity*Time.deltaTime);


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
