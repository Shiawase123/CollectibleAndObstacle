using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;
    public bool isGameOver = false;

    public TextMeshProUGUI scoreText; 

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        UpdateScoreUI();
    }

    public void AddScore(int points)
    {
        if (isGameOver) return;

        score += points;
        UpdateScoreUI();
        Debug.Log("Score: " + score);
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    public void GameOver()
    {
        if (isGameOver) return;

        isGameOver = true;
        Debug.Log("GAME OVER! Final Score: " + score);
        Time.timeScale = 0;
    }
}