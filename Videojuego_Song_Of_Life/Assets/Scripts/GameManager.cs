using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public GameObject[] targetPrefabs;
    public TextMeshProUGUI scoreText;
    private int score;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int pointsToAdd)
    {
        score += pointsToAdd;
        scoreText.text = $"Score: {score}";
        
    }

    public void GameOver()
    {
        gameOver = true;
        
    }

    public void StartGame()
    {
        
        score = 0;
        UpdateScore(0);
        gameOver = false;
        
    }
}
