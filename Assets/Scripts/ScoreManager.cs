using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{   
    public int rightScore = 0;
    public int leftScore = 0;

    public int maxScore = 10;

    public BallController ball;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddRightScore(int increment){
        ball.ResetPosition();
        rightScore += increment;
        if(rightScore >= maxScore){
            GameOver();
        }
    }

    public void AddLeftScore(int increment){
        ball.ResetPosition();
        leftScore += increment;
        if(leftScore >= maxScore){
            GameOver();
        }
    }

    public void GameOver(){
        SceneManager.LoadScene("MainMenu");
    }
}
