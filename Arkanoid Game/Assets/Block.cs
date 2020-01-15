using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour
{
    public float score;
    //[SerializeField] public Text scoreText;

     void Start()
    {
        score = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
        Debug.Log(collision.gameObject.name); //What collided with the object? Debug purposes
    }

    private void DestroyBlock()
    {
        FindObjectOfType<ScoreManager>().addScore();
        Destroy(gameObject);
    }
}
