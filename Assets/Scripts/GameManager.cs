using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Score Settings")]
    public int coinCount = 0;
    public int coinsToWin = 7;
    public Text scoreText; // Drag your Score Text UI here in Inspector

    [Header("Checkpoint Settings")]
    private Vector3 lastCheckpointPos;
    private GameObject player;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        if (player != null)
            lastCheckpointPos = player.transform.position;

        UpdateScoreUI();
    }

    // Call this to increment coins
    public void AddCoin()
    {
        coinCount++;
        UpdateScoreUI();
        Debug.Log("Coins collected: " + coinCount + "/" + coinsToWin);

        if (coinCount >= coinsToWin)
        {
            Debug.Log("All coins collected! Loading Win Screen...");
            SceneManager.LoadScene("WinScreen"); // Make sure the scene name matches exactly
        }
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + coinCount;
    }

    // Save checkpoint
    public void SetCheckpoint(Vector3 checkpointPos)
    {
        lastCheckpointPos = checkpointPos;
        Debug.Log("Checkpoint saved at: " + lastCheckpointPos);
    }

    // Respawn player at last checkpoint
    public void RespawnPlayer()
    {
        if (player == null)
            player = GameObject.FindWithTag("Player");

        if (player != null)
            player.transform.position = lastCheckpointPos;
    }
}