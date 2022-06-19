using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleGrowController : PaddlePowerController, IPaddlePower
{
    public float growScale = 1f;
    // Start is called before the first frame update
    private GameObject _paddle;
    void Start()
    {

    }

    
    public void OnExpired(){
        Vector3 scale = _paddle.transform.localScale;
        scale.y /= growScale;
        _paddle.transform.localScale = -scale;
    }

    public void Buff(GameObject paddle)
    {
        _paddle = paddle;
        Vector3 scale = _paddle.transform.localScale;
        scale.y *= growScale;
        _paddle.transform.localScale = scale;
        gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<Collider2D>().enabled = false;

        StartCoroutine(HandleExpiration(this));
    }

}
