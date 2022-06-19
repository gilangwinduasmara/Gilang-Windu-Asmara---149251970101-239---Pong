using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddlePowerController : MonoBehaviour
{
    public float buffDuration = 5f;

    public PowerUpManager powerUpManager;
    public IEnumerator HandleExpiration(IPaddlePower paddle)
    {
        yield return new WaitForSeconds(buffDuration);
        paddle.OnExpired();
        powerUpManager.RemovePowerUp(gameObject);

    }

    void Update(){
        Spin();
    }

    void Spin(){
        transform.Rotate(0, Time.deltaTime * 100, 0);
    }
}
