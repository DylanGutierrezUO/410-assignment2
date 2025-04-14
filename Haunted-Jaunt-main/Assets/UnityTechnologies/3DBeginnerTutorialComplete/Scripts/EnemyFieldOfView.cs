using UnityEngine;

public class EnemyFieldOfView : MonoBehaviour
{
    public Transform player;
    public float detectionRange = 5f;
    public float fieldOfViewAngle = 60f;

    public GameObject alertIndicatorPrefab; // Prefab to instantiate
    public Vector3 alertOffset = new Vector3(0, 2f, 0); // Offset above enemy

    public AudioSource alertSound;

    private GameObject alertInstance;
    private bool playerInView = false;

    void Start()
    {
        // Instantiate the indicator above the enemy
        if (alertIndicatorPrefab != null)
        {
            alertInstance = Instantiate(alertIndicatorPrefab, transform.position + alertOffset, Quaternion.identity);
            alertInstance.transform.SetParent(transform); // Keep it above the enemy
            alertInstance.SetActive(false);
        }
    }

    void Update()
    {
        if (player == null || alertInstance == null) return;

        Vector3 directionToPlayer = player.position - transform.position;
        float distanceToPlayer = directionToPlayer.magnitude;

        if (distanceToPlayer < detectionRange)
        {
            directionToPlayer.Normalize();
            float dot = Vector3.Dot(transform.forward, directionToPlayer);
            float angle = Mathf.Acos(dot) * Mathf.Rad2Deg;

            if (angle < fieldOfViewAngle / 2f)
            {
                if (!playerInView)
                {
                    Debug.Log("Player is in view!");
                    alertInstance.SetActive(true);

                    if (alertSound != null && !alertSound.isPlaying)
                        alertSound.Play();

                    playerInView = true;
                }
                return;
            }
        }

        if (playerInView)
        {
            Debug.Log("Player left view.");
            alertInstance.SetActive(false);
            playerInView = false;
        }
    }
}
