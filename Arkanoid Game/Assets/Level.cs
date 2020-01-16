using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{

    [SerializeField] int breakableBlocks; //Debug purposes

    //Cache reference
    LevelManager sceneLoader;

    private void Start()
    {
        sceneLoader = FindObjectOfType<LevelManager>();
    }
    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;

        if(breakableBlocks <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
