 using UnityEngine;

public class PlayMovement : MonoBehaviour
{
    // this is a refrence to rigidbody called rb
    public Rigidbody rb;

    public float forwaedForce = 2000f;
    public float sidawaysForce = 500f;


    // We marked this as "Fixed"Update because we
    // are is to mess with physic.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwaedForce * Time.deltaTime); //Add a forward force 

        if( Input.GetKey("d"))
        {
            rb.AddForce(sidawaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

         if( Input.GetKey("a"))
        {
            rb.AddForce(-sidawaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    
    } 
}
