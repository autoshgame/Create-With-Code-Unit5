using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] protected List<GameObject> targets;

    private int score;

    [SerializeField] TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score : " + score.ToString();
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
}
