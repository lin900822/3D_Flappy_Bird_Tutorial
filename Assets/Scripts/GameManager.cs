using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Score;
    public bool IsGameOver;

    public void AddScore()
    {
        Score++;
    }

    public void SetGameOver()
    {
        IsGameOver = true;
    }
}
