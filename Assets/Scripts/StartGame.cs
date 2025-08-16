using TMPro;
using UnityEngine;
using UnityEngine.UI;

// This class is used to start the game.

public class StartGame : MonoBehaviour
{
    [SerializeField] GameObject pipeSpawner;
    [SerializeField] BirdScript _birdScript;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI highScoreText;
    [SerializeField] Button startButton;

    void Start()
    {
        transform.GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    public void StartTheGame()
    {
        transform.GetComponent<Rigidbody2D>().gravityScale = 2;
        pipeSpawner.SetActive(true);
        _birdScript.enabled = true;
        scoreText.gameObject.SetActive(true);
        startButton.gameObject.SetActive(false);
    }
}
