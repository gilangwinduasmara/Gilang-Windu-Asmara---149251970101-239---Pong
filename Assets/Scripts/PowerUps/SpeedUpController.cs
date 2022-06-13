using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpController : MonoBehaviour
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


    private void OnTriggerEnter2D(Collider2D collison) {
        if(collison == ball) {
            ball.GetComponent<ISpeedUp>().PowerSpeedUp(magnitude);
            powerUpManager.RemovePowerUp(gameObject);
        }
    }
}
