using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    private int playerScore = 0;
    public TMP_Text scoreText;
    public GameObject gameOverScreen;
    public bool isBirdAlive = true;

    public void AddScore(int score)
    {
        if (isBirdAlive)
        {
            playerScore += score;
            scoreText.text = playerScore.ToString();
        }
    }

    public void RestartGame()
    {
        Debug.Log("Restarting Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        isBirdAlive = false;
        gameOverScreen.SetActive(true);
    }
}
