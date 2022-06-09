using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider2D ball;
    public bool isRight;
    public ScoreManager scoreManager;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other == ball) {
            if (isRight) {
                scoreManager.AddRightScore(1);
            } else {
                scoreManager.AddLeftScore(1);
            }
        }
    }
}
