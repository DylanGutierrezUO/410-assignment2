using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void LateUpdate()
    {
        if (mainCamera != null)
        {
            // Look at the camera, but keep the Y-axis upright
            Vector3 lookDirection = mainCamera.transform.position - transform.position;
            lookDirection.y = 0; // Optional: remove pitch for a flat billboard
            transform.rotation = Quaternion.LookRotation(lookDirection);
        }
    }
}
