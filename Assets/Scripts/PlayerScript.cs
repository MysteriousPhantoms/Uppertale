using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    [Header("Movement")]
    public Rigidbody2D RB;
    public float Speed = 2f;

    [Header("Score")]
    public TextMeshPro ScoreText;
    public int Score = 0;

    void Start()
    {
        UpdateScore();
    }

    void Update()
    {
        // Handle movement
        Vector2 vel = Vector2.zero;

        if (Input.GetKey(KeyCode.D)) vel.x = Speed;
        if (Input.GetKey(KeyCode.A)) vel.x = -Speed;
        if (Input.GetKey(KeyCode.W)) vel.y = Speed;
        if (Input.GetKey(KeyCode.S)) vel.y = -Speed;

        RB.linearVelocity = vel;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Hazard"))
        {
            Die();
        }
    }

    public void UpdateScore()
    {
        if (ScoreText != null)
            ScoreText.text = "Score: " + Score;
    }

    public void Die()
    {
        SceneManager.LoadScene("Game Over"); // Make sure scene name matches exactly
    }
}
