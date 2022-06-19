using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpController : MonoBehaviour, IBallPower
{
    public PowerUpManager powerUpManager;
    public Collider2D ball;
    public float magnitude;

    public float timeToLive;
    private float _timeSinceLastSpawn;

    public void Start()
    {
        _timeSinceLastSpawn = 0;
    }

    public void Update()
    {
        _timeSinceLastSpawn += Time.deltaTime;

        if (_timeSinceLastSpawn > timeToLive)
        {
            _timeSinceLastSpawn -= timeToLive;
            powerUpManager.RemovePowerUp(gameObject);
        }
        transform.Rotate(0, Time.deltaTime * 100, 0);

    }

    public void Buff(BallController ball){
        ball.GetComponent<Rigidbody2D>().velocity = ball.GetComponent<Rigidbody2D>().velocity * magnitude;
        powerUpManager.RemovePowerUp(gameObject);
    }
}
