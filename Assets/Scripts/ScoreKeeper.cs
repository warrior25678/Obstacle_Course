using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    ScoreKeeper instance;

    [SerializeField] int score = 0;
    [SerializeField] float timer;
    public bool isPlaying = false;
    private void Awake()
    {
        ManageSingleton();
    }

    void Update()
    {
        if (isPlaying)
        {
            timer = Time.timeSinceLevelLoad;
        }
    }
    public void ResetScore()
    {
        score = 0;
        timer = 0f;
    }

    public int GetScore()
    {
        return score;
    }
    public float GetTimer()
    {
        return timer;
    }
    public void IncreaseScore()
    {
        score++;
    }

    void ManageSingleton()
    {
        if (instance != null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
