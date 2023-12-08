using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOverText;
    public bool gameOver = false;

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
            
        }
    }

    public void birdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
    
}