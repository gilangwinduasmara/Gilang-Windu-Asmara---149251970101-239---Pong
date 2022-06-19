using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    public Vector2 initialPosition;
    public GameObject lastHitBy;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.velocity = speed;
    }

    public void ResetPosition(){
        transform.position = new Vector3(initialPosition.x, initialPosition.y, 2);
        lastHitBy = null;
    }
    

    public void Buff(){
        _rigidbody.velocity = speed * 2;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        IPaddlePower paddlePower = other.gameObject.GetComponent<IPaddlePower>();
        IBallPower ballPower = other.gameObject.GetComponent<IBallPower>();
        if(paddlePower != null && lastHitBy != null){
            paddlePower.Buff(lastHitBy);
        } 
        else if(ballPower != null){
            ballPower.Buff(this);
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.GetComponent<PaddleController>() != null){
            Debug.Log("Lashit: " + other.gameObject.name);
            lastHitBy = other.gameObject;
        }
    }
}
