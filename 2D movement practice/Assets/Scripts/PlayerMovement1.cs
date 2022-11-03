using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    private Vector2 movement;
    private Rigidbody2D myBody;
//------------------------------------------------------------------------------------

    //speed value
    [SerializeField] private int speed = 5;

// -----------------------------------------------------------------------------------
private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }
//------------------------------------------------------------------------------------
private void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();
    }
//------------------------------------------------------------------------------------
private void FixedUpdate()
    {
        myBody.velocity = movement * speed;
    }
//------------------------------------------------------------------------------------
}