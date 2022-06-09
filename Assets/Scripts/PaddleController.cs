using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed = 2;
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
        // Vector3 movement = Vector3.zero;
        // if(Input.GetKey(KeyCode.W)) {
        //     movement = Vector3.up * speed;
        // }
        // else if(Input.GetKey(KeyCode.S)) {
        //     movement = Vector3.down * speed;
        // }
        // transform.Translate(movement * Time.deltaTime);
    }

    private Vector2 GetMovement(){
        Vector2 movement = Vector2.zero;
        if(Input.GetKey(upKey)) {
            movement = Vector2.up * speed;
        }
        else if(Input.GetKey(downKey)) {
            movement = Vector2.down * speed;
        }
        return movement;
    }

    private void Move(Vector2 movement){
        // transform.Translate(movement * Time.deltaTime);
        _rigidbody.velocity = movement;
    }
}
