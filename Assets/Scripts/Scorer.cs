using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    ScoreKeeper scoreKeeper;
    GameManager gameManager;
    private void Awake()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    private void OnCollisionEnter(Collision other)
    {
        scoreKeeper.IncreaseScore();
    }
    private void OnTriggerEnter(Collider other)
    {
        gameManager.LoadGameOver();
    }
}
