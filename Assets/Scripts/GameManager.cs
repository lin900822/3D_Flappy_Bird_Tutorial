using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Score;
    public bool IsGameOver;

    [SerializeField] private TMP_Text scoreText;

    [SerializeField] private GameObject gameOverMenu;

    [SerializeField] private TMP_Text gameOverScoreText;
    [SerializeField] private TMP_Text gameOverBestScoreText;

    public void AddScore()
    {
        Score++;
        scoreText.text = Score.ToString();
    }

    public void SetGameOver()
    {
        IsGameOver = true;

        gameOverMenu.SetActive(true);

        int bestScore = PlayerPrefs.GetInt("BestScore", 0);

        if(Score > bestScore)
        {
            bestScore = Score;
            PlayerPrefs.SetInt("BestScore", bestScore);
        }

        gameOverScoreText.text = "Score : " + Score.ToString();
        gameOverBestScoreText.text = "Best Score : " + bestScore.ToString();
    }

    public void Retry()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
