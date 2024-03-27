using UnityEngine;

public class collisioneffect : MonoBehaviour
{
    public AudioSource CollisionSound;

    void OnCollisionEnter(Collision collision)
    {
        CollisionSound.Play();
    }


}
