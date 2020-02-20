using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public float score;
    public float blockDestroyed = 50f;
    [SerializeField] public Text scoreText;

    void Start()
    {
        score = 0;
        SetScoreText();
    }

    public void addScore()
    {
        score += blockDestroyed;
        SetScoreText();
    }

    public void SetScoreText() //Keeping score method
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
