using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    ScoreKeeper instance;

    [SerializeField] int score = 0;
    private void Awake()
    {
        ManageSingleton();
    }


    public void ResetScore()
    {
        score = 0;
    }

    public int GetScore()
    {
        return score;
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
