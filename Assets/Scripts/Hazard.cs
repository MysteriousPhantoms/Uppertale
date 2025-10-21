using UnityEngine;

public class HazardController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.RespawnPlayer();
        }
    }
}