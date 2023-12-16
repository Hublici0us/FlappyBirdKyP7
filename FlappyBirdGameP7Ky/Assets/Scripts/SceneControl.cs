using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    private void Awake()
    {
        loadStartScene();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            loadGameScene();
        }
    }

    void loadStartScene()
    {
        SceneManager.LoadScene(sceneName: "IntroScene");
    }

    void loadGameScene()
    {
        SceneManager.LoadScene(sceneName: "PlayScene");
    }
}
