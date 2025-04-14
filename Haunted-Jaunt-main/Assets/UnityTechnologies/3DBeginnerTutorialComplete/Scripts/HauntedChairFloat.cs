using UnityEngine;

public class HauntedChairFloat : MonoBehaviour
{
    public Transform floatPointA;
    public Transform floatPointB;
    public float floatSpeed = 1f;

    public float rotationSpeedMin = 10f;
    public float rotationSpeedMax = 60f;
    public float rotationLerpSpeed = 0.5f;  // how quickly the rotation speed changes

    void Update()
    {
        if (floatPointA == null || floatPointB == null) return;

        // --- FLOATING ---
        float t = (Mathf.Sin(Time.time * floatSpeed) + 1f) / 2f;
        transform.position = Vector3.Lerp(floatPointA.position, floatPointB.position, t);

        // --- ROTATING (LERP over time) ---
        float rotT = (Mathf.Sin(Time.time * rotationLerpSpeed) + 1f) / 2f;
        float currentRotationSpeed = Mathf.Lerp(rotationSpeedMin, rotationSpeedMax, rotT);
        transform.Rotate(0f, currentRotationSpeed * Time.deltaTime, 0f);
    }
}
