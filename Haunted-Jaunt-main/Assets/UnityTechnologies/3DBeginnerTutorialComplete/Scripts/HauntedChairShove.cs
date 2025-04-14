using UnityEngine;

public class HauntedChairShove : MonoBehaviour
{
    public float shoveForce = 5f;

    void OnCollisionEnter(Collision collision)
    {
        Rigidbody otherRb = collision.collider.attachedRigidbody;

        if (otherRb != null && otherRb.CompareTag("Player"))
        {
            Vector3 pushDirection = (collision.transform.position - transform.position).normalized;
            pushDirection.y = 0f; // Keep it horizontal
            otherRb.AddForce(pushDirection * shoveForce, ForceMode.Impulse);
        }
    }
}
