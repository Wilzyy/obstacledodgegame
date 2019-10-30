using UnityEngine;

// HI CONOR AAAAAAAAAAAAAAAAAAAAAAAAAA

public class PlayerMovement : MonoBehaviour

{
  public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // I marked this with "FixedUpdate" because I am messing around with the physics".
    void FixedUpdate()

    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // adds a force of 2000 on the Z-axis

        if ( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }


    }

}
