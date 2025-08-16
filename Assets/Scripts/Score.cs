using TMPro;
using UnityEngine;

// This class handles the score system.

public class Score : MonoBehaviour
{
    public int score;
    public int highScore;
    [SerializeField] TextMeshProUGUI scoreText;

    void Awake()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
    }

    void Start()
    {
        score = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Scorer"))
        {
            score++;

            if (score > highScore)
            {
                highScore = score;
            }

            scoreText.text = score.ToString();
            AudioManager.instance.PlaySFX(1);
        }
    }
}
