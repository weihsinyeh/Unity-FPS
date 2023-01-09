using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    static public int score { get; private set; }
    Text scoreText;

    void Start(){
        score = 0;
        scoreText = GetComponent<Text>();
    }

    void Update(){
        scoreText.text = "Score : " + score.ToString();
    }

    public void AddScore(int score){
        Score.score += score;
    }
    public void MinusScore(int score){
        Score.score -= score;
    }
}
