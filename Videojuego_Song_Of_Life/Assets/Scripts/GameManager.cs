using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public GameObject[] targetPrefabs;
    public TextMeshProUGUI scoreText;
    private int score;


    public GameObject gameOverPanel;
    private AudioSource playerAudioSource;
    public AudioClip targetClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 200f)
        {
            gameOver = true;
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
            playerAudioSource.PlayOneShot(targetClip);
        }
    }

    public void UpdateScore(int pointsToAdd)
    {
        score += pointsToAdd;
        scoreText.text = $"Score: {score}";
        
    }

    public void GameOver()
    {
        if (score == 100f)
        {
            gameOver = true;
            gameOverPanel.SetActive(true);
        }
    }

    public void StartGame()
    {
        
        score = 0;
        UpdateScore(0);
        gameOver = false;
        
    }
    
}
