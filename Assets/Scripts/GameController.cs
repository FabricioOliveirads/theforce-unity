using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public int Score;
    public int CoinScore;
    public Text scoreText;
    public Text coinText;
    public float ScorePerSecond;
    public static GameController current;
    public bool playerIsAlive;
    float ScoreUpdate;
    void Start()
    {
        playerIsAlive = true;
        current = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.current.playerIsAlive)
        {
            ScoreUpdate += ScorePerSecond * Time.deltaTime;
            Score = (int)ScoreUpdate;
            scoreText.text = Score.ToString("0000");
        }
    }

    public void AddScore(int value)
    {
        CoinScore += value;
        coinText.text = CoinScore.ToString("0000");
    }
}
