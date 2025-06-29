using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// This class is used to restart the game after game overs.

public class GameOver : MonoBehaviour
{
    [SerializeField] Button restartButton;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe") || collision.gameObject.CompareTag("NoTouch"))
        {
            Time.timeScale = 0f;
            restartButton.gameObject.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
