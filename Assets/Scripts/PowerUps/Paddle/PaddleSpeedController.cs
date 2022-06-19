using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSpeedController : PaddlePowerController, IPaddlePower
{
    public float speedScale = 1f;
    // Start is called before the first frame update
    private GameObject _paddle;
    void Start()
    {

    }

    
    public void OnExpired(){
        _paddle.GetComponent<PaddleController>().speed /= speedScale;
    }

    public void Buff(GameObject paddle)
    {
        _paddle = paddle;
        Vector3 scale = _paddle.transform.localScale;
        _paddle.GetComponent<PaddleController>().speed *= speedScale;
        gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<Collider2D>().enabled = false;

        StartCoroutine(HandleExpiration(this));
    }

}
