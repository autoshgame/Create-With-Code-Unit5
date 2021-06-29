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
    [SerializeField] protected GameObject pauseScreen;
    [SerializeField] protected GameObject middldeScreen;
    [SerializeField] protected List<GameObject> targets;

    private int score;
    private int lives = 3;
    public int Lives
    {
        get
        {
            return lives;
        }
    }

    [SerializeField] protected TextMeshProUGUI scoreText;
    [SerializeField] protected TextMeshProUGUI totalScore;
    [SerializeField] protected TextMeshProUGUI livesText;

    [SerializeField] protected bool isGameOver;

    [SerializeField] protected Button restartButton;
    [SerializeField] protected Button resumeButton;
    [SerializeField] protected Button retryButton;
    [SerializeField] protected Button mediumButton;
    [SerializeField] protected Button hardButton;
    [SerializeField] protected Button exitButton;

    private void Awake()
    {
        tileScreen.gameObject.SetActive(true);
        endScreen.gameObject.SetActive(false);
        middldeScreen.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(true);
        pauseScreen.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "Lives : " + lives.ToString();
    }

     // Update is called once per frame
    void Update()
    {
    
    }


    private void OnGUI()
    {
        UpdateLives();
    }


    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score : " + score.ToString();
    }



    public void UpdateLives()
    {
        livesText.text = "Lives : " + lives.ToString();
    }


    public bool IsGameOver()
    {
        return isGameOver;
    }


    public void GameOver()
    {
        isGameOver = true;
        middldeScreen.gameObject.SetActive(false);
        endScreen.gameObject.SetActive(true);

        //Let the scoretext move to another position because of having bug in rendering
        middldeScreen.gameObject.transform.position = new Vector3(-999, 699, 0);

        totalScore.text = "Total score : " + score.ToString();
    }
    

    public void ReloadGame()
    {
        SceneManager.LoadScene("Prototype 5");
        Time.timeScale = 1;
        isGameOver = false;
    }


    public void StartGame()
    {
        isGameOver = false;
        tileScreen.gameObject.SetActive(false);
        middldeScreen.gameObject.SetActive(true);
        exitButton.gameObject.SetActive(false);
        UpdateScore(0);
    }


    public void ExitApplication()
    {
        Application.Quit();
    }


    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseScreen.gameObject.SetActive(true);
        middldeScreen.gameObject.SetActive(false);
    }


    public void ReturnGame()
    {
        Time.timeScale = 1;
        pauseScreen.gameObject.SetActive(false);
        middldeScreen.gameObject.SetActive(true);
    }


    public void decreaseLives()
    {
        lives--;
    }
    
}
