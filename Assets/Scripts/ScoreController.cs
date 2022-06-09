using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreController : MonoBehaviour
{
    public Text leftScore;
    public Text rightScore;

    public ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftScore.text = scoreManager.leftScore.ToString();
        rightScore.text = scoreManager.rightScore.ToString();
    }
}
