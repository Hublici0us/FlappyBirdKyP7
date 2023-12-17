using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOverText;
    public TMP_Text scoreText;
    public TMP_Text highScoreText;
    public bool gameOver = false;
    public float scrollSpeed;
    private int score = 0;
   

    // Start is called before the first frame update
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
        //singleton pattern: useful for needing one objecct to coordinate things across the system.
    }

    private void Start()
    {
        UpdateHighScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        checkHighScore();
        if (gameOver == true && Input.GetKeyDown(KeyCode.Space)) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void birdScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "Score :" + score.ToString();

    }

    public void birdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }

    void checkHighScore()
    {
        if (score > PlayerPrefs.GetInt("High Score", 0))
        {
            PlayerPrefs.SetInt("High Score", score);
            UpdateHighScoreText();
        }
    }

    void UpdateHighScoreText()
    {
        highScoreText.text = $"High Score: {PlayerPrefs.GetInt("High Score", 0)}";
    }
}
