using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject metalHead;
    public Canvas gameCanvas;
    public bool gameStarted;
    public GameObject scrollObjects;
    public Behaviour gameControl;

    // Start is called before the first frame update
    void Start()
    {
        gameStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStarted == false)
        {
            gameControl.enabled = false;
            metalHead.SetActive(false);
            scrollObjects.SetActive(false);
            gameCanvas.enabled = false;
        }
        else if (gameStarted == true)
        {
            titleScreen.SetActive(false );
            gameControl.enabled = true;
            metalHead.SetActive(true); 
            scrollObjects.SetActive(true);
            gameCanvas.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && gameStarted == false)
        {
            gameStarted = true;
        }

        if (GameControl.instance.gameOver == true && Input.GetKeyDown(KeyCode.Escape))
        {
            gameControl.enabled = false;
            titleScreen.SetActive(true);
        }
    }

    public void gameStart()
    {

        titleScreen.SetActive(false);

    }


}
