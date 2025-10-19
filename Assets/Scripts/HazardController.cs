using UnityEngine;

public class BouncingHazard : MonoBehaviour
{
    public float speed = 15f;     // fast speed
    public float topLimit = 3f;   // top bounce point
    public float bottomLimit = -3f; // bottom bounce point

    private Vector3 direction = Vector3.up;

    void Update()
    {
        // Move in the current direction
        transform.position += direction * speed * Time.deltaTime;

        // Check limits and flip direction
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
