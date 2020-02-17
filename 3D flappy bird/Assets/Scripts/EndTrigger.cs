using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public CameraFollow cameraFollowScript;
    public PlayerMovement movementScript;
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        cameraFollowScript.enabled = false;
        movementScript.enabled = false;
        gameManager.levelComplete();
    }
}
