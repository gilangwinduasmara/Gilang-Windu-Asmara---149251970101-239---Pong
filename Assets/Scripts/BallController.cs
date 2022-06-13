using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour, ISpeedUp
{
    public Vector2 speed;
    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    public Vector2 initialPosition;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.velocity = speed;
    }

    public void ResetPosition(){
        transform.position = new Vector3(initialPosition.x, initialPosition.y, 2);
    }

    public void PowerSpeedUp(float magnitude)
    {
        _rigidbody.velocity *= magnitude;
    }
}
