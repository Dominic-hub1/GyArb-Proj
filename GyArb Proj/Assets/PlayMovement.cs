 using UnityEngine;

public class PlayMovement : MonoBehaviour
{
    // this is a refrence to rigidbody called rb
    public Rigidbody rb;

    // We marked this as "Fixed"Update because we
    // are is to mess with physic.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime); //Add a force to z axis 2000
    } 
}
