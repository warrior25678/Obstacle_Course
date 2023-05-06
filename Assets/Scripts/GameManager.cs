using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    ScoreKeeper scoreKeeper;
    private void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    [SerializeField] float loadDelay = 2f;
    public void LoadGame()
    {
        scoreKeeper.ResetScore();
        SceneManager.LoadScene("MainGame");
    }
    public void LoadGameOver()
    {
        StartCoroutine(LoadAfterDelay("GameOver", loadDelay));
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    IEnumerator LoadAfterDelay(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}
