using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public void MenuBtn()
    {
        SceneManager.LoadScene("Start Menu"); //Loads Start Menu scene on Button Click
    }

    public void PlayBtn()
    {
        SceneManager.LoadScene("Level 1"); //Loads Level 1 scene on Button Click
    }

    public void ExitBtn()
    {
        SceneManager.LoadScene("Game Over"); //Loads Game Over scene on Button Click at the moment (Will be removed later)
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }




    void Start()
    {
        
    }

    void Update()
    {
        
    }


}
