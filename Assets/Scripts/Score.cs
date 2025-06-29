using TMPro;
using UnityEngine;

// This class handles the score system.

public class Score : MonoBehaviour
{
    private float score;
    [SerializeField] TextMeshProUGUI scoreText;

    void Start()
    {
        score = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Scorer"))
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
}
