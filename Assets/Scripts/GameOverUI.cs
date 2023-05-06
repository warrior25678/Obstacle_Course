using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI timerText;
    ScoreKeeper scoreKeeper;
    private void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        float timeElapsed = scoreKeeper.GetTimer();
        timerText.text = ("You completed the course in: " + ((int)timeElapsed / 60).ToString() + ":" + (timeElapsed % 60).ToString("f2"));
        scoreText.text = ("You hit " + scoreKeeper.GetScore() + " objects!");
    }


}
