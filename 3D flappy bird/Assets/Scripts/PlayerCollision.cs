using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movementScript;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacles")
        {
            movementScript.enabled = false;
        }
    }
}
