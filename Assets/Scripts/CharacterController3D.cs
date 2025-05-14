using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController3D : MonoBehaviour
{
    private Rigidbody myRB;
    private Vector2 movementInput;
    public float speed;
    public float jumpForce;
    private void Awake()
    {
        myRB = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        myRB.velocity = new Vector3(movementInput.x * speed, myRB.velocity.y, movementInput.y * speed);
    }
    public void OnMovement(InputAction.CallbackContext context)
    {
        if (context.performed || context.canceled)
        {
            movementInput = context.ReadValue<Vector2>();
        }
    }
    public void OnJump()
    {

    }
    public void ApplyPhysics()
    {

    }
}
