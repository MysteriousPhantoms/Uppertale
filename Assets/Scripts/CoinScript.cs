using UnityEngine;

public class CoinScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && GameManager.instance != null)
        {
            // Add coin to GameManager
            GameManager.instance.AddCoin();

            // Save checkpoint at this coin's position
            GameManager.instance.SetCheckpoint(transform.position);

            // Hide the coin visually
            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}