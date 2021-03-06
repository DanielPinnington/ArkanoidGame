﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour
{
    public float score;
    [SerializeField] AudioClip breakSound;

    //Cache reference
    Level level;

    //[SerializeField] public Text scoreText;

     void Start()
    {
        level = FindObjectOfType<Level>(); //Counting the amount of blocks in the scene
        level.CountBreakableBlocks();
      //  score = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position); //Play clip on the camera position (2D)
        DestroyBlock();
        level.BlockDestroyed();
        Debug.Log(collision.gameObject.name); //What collided with the object? Debug purposes
    }

    private void DestroyBlock()
    {
        FindObjectOfType<Status>().AddToScore();
        Destroy(gameObject);
    }
}
