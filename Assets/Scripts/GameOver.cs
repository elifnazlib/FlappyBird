using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// This class is used to restart the game after game overs.

public class GameOver : MonoBehaviour
{
    [SerializeField] Button restartButton;
    [SerializeField] BirdScript _birdScript;
    [SerializeField] Score _scoreScript;
    [SerializeField] TextMeshProUGUI scoreOnTheScreen;
    [SerializeField] TextMeshProUGUI endScoreText;
    [SerializeField] TextMeshProUGUI endHighScoreText;
    [SerializeField] GameObject endOfGamePanel;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe") || collision.gameObject.CompareTag("NoTouch"))
        {
            Time.timeScale = 0f;
            restartButton.gameObject.SetActive(true);
            scoreOnTheScreen.gameObject.SetActive(false);
            _birdScript.enabled = false;
            AudioManager.instance.PlaySFX(2);
            AudioManager.instance.PlaySFX(3);

            PlayerPrefs.SetInt("HighScore", _scoreScript.highScore);

            endOfGamePanel.SetActive(true);
            endScoreText.text = _scoreScript.score.ToString();
            endHighScoreText.text = _scoreScript.highScore.ToString();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
