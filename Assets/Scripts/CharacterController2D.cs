using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController2D : MonoBehaviour
{
    private Rigidbody2D myRgbd2d;
    public int speed;
    private Vector2 movementInput;
    private void Awake()
    {
        myRgbd2d = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        myRgbd2d.linearVelocity = movementInput * speed;
    }
    public void OnMoving(InputAction.CallbackContext context)
    {
        if (context.performed || context.canceled)
        {
            movementInput = context.ReadValue<Vector2>();
        }
    }
}