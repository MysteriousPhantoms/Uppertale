using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreenScript : MonoBehaviour
{
    public void PlayAgain()
    {
        // If GameManager still tracks coins, reset it safely
        if (GameManager.instance != null)
        {
            // Check if the GameManager has coinCount before trying to reset it
            // (Only do this if you still use coins for a win condition)
            // Example:
            // GameManager.instance.coinCount = 0;
        }

        // Load your main gameplay scene (replace "Example 3" with your real level name)
        SceneManager.LoadScene("Example 3");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}