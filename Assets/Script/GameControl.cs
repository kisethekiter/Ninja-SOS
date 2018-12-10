using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.Audio;

public class GameControl : MonoBehaviour
{

    public static GameControl instance;

    public float scrollSpeed = -1.5f;
    public bool isGameOver = false;
    private int score = 0;

    public Text scoreText;
    public GameObject gameOverText;

    public AudioSource SmokeySound;
    private float speedracer = 1.01f;
    private int scoretracker = 1;

    void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }


    void Update()
    {
        if (isGameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void Score()
    {
        if (isGameOver) { return; }
        score++;
        scoreText.text = "score: " + score;
        SmokeySound.Play();
        speed();

    }

    public void Die()
    {
        isGameOver = true;
        gameOverText.SetActive(true);
    }

    public void speed()
    {
        
        if (score%10==0)
        {
            
            scrollSpeed = scrollSpeed * speedracer;
            scoretracker++;
            
        }
    }

}




 