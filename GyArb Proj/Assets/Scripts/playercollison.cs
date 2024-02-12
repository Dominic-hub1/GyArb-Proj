using UnityEngine;

public class playercollison : MonoBehaviour
{

    public PlayMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<Gamemanager>().EndGame();
        }
    }
}
