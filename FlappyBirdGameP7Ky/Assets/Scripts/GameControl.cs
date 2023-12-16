using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOverText;
    public TMP_Text scoreText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;
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

    // Update is called once per frame
    void Update()
    {
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
    
}
