using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public TMPro.TextMeshProUGUI scoreText;

    private void Start() {
        scoreText.text = "Score: " + score;
    }

    public void IncrementScore(){
        score++;
        scoreText.text = "Score: " + score;
    }
}
