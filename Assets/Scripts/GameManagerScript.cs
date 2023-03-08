using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverPanel;

    [ContextMenu("Add Score")]
    public void AddScore(int scoreToAdd) {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void GameOver() {
        gameOverPanel.SetActive(true);
    }

    public void RestartGame() {
        string currentSceneName = SceneManager.GetActiveScene().name;

        SceneManager.LoadScene(currentSceneName);
    }
}
