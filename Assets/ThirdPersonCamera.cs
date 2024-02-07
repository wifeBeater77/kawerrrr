using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target;  // The player object to follow
    public float distance = 5.0f;  // Distance from the player
    public float height = 2.0f;    // Height of the camera above the player
    public float smoothSpeed = 5.0f;  // Speed of camera movement

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogError("Target not assigned for the ThirdPersonCamera script.");
            return;
        }

        // Calculate the desired position for the camera
        Vector3 desiredPosition = target.position + Vector3.up * height - target.forward * distance;

        // Smoothly move the camera towards the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        // Make the camera look at the player
        transform.LookAt(target);
    }
}