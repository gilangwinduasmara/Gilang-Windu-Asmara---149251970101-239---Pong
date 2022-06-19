using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 2;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(GetMovement());
    }

    private Vector2 GetMovement(){
        Vector2 movement = Vector2.zero;
        if(Input.GetKey(upKey)) {
            movement = Vector2.up * speed;
        }
        else if(Input.GetKey(downKey)) {
            movement = Vector2.down * speed;
        }
        // Debug.Log("Paddle Speed: " + movement);
        return movement;
    }

    private void Move(Vector2 movement){
        _rigidbody.velocity = movement;
    }


   
}
