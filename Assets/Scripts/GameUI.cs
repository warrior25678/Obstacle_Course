using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI timerText;
    ScoreKeeper scoreKeeper;
    private void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    private void Update()
    {
        float timeElapsed = scoreKeeper.GetTimer();
        scoreText.text = ("Score: " + scoreKeeper.GetScore());
        timerText.text = (((int)timeElapsed / 60).ToString() + ":" + (timeElapsed % 60).ToString("f2"));
    }
}
