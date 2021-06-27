using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] protected GameObject tileScreen;
    [SerializeField] protected GameObject endScreen;
    [SerializeField] protected List<GameObject> targets;

    private int score;

    [SerializeField] protected TextMeshProUGUI scoreText;
    [SerializeField] protected TextMeshProUGUI totalScore;

    [SerializeField] protected bool isGameOver;

    [SerializeField] protected Button restartButton;
    [SerializeField] protected Button mediumButton;
    [SerializeField] protected Button hardButton;
    [SerializeField] protected Button exitButton;

    private void Awake()
    {
        tileScreen.gameObject.SetActive(true);
        endScreen.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

     // Update is called once per frame
    void Update()
    {
       
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
        scoreText.gameObject.SetActive(false);
        endScreen.gameObject.SetActive(true);

        //Let the scoretext move to another position because of having bug in rendering
        scoreText.gameObject.transform.position = new Vector3(-222, 699, 0);

        totalScore.text = "Total score : " + score.ToString();
    }
    

    public void ReloadGame()
    {
        SceneManager.LoadScene("Prototype 5");
        isGameOver = false;
    }


    public void StartGame()
    {
        isGameOver = false;
        tileScreen.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(true);
        exitButton.gameObject.SetActive(false);
        UpdateScore(0);
    }


    public void exitApplication()
    {
        Application.Quit();
    }
}
