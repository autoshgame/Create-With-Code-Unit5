using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] protected List<GameObject> targets;

    private int score;

    [SerializeField] TextMeshProUGUI scoreText;

    [SerializeField] protected bool isGameOver;

    [SerializeField] protected Button restartButton;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score : " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            GameOver();
        }
    }


    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score : " + score.ToString();
    }


    public bool IsGameOver()
    {
        return isGameOver;
    }

    public void GameOver()
    {
        isGameOver = true;
        restartButton.gameObject.SetActive(true);
    }
    

    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        isGameOver = false;
    }
}
