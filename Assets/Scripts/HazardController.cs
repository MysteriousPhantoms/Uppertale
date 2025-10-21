using UnityEngine;

public class BouncingHazard : MonoBehaviour
{
    [Header("Bounce Settings")]
    public float speed = 9f;       // Bounce speed
    public float topLimit = 3f;     // Top bounce point
    public float bottomLimit = -3f; // Bottom bounce point

    [Header("Rotation Settings")]
    public float rotationSpeed = 360f; // Degrees per second for rotation

    private Vector3 direction = Vector3.up;

    void Update()
    {
        // 🔴 If this is the rotating hazard, just rotate — no bouncing
        if (gameObject.name == "Hazard Rotate")
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
            return;
        }

        // 🟡 Otherwise, bounce normally
        transform.position += direction * speed * Time.deltaTime;

        if (transform.position.y >= topLimit)
        {
            direction = Vector3.down;
        }
        else if (transform.position.y <= bottomLimit)
        {
            direction = Vector3.up;
        }
    }
}