using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController3D : MonoBehaviour
{
    private Rigidbody myRB;
    private Vector2 movementInput;
    public float speed;
    public float jumpForce;
    private bool jumpInput;
    private void Awake()
    {
        myRB = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        myRB.velocity = new Vector3(movementInput.x * speed, myRB.velocity.y, movementInput.y * speed);
        if (jumpInput)
        {
            myRB.velocity = new Vector3(myRB.velocity.x, myRB.velocity.y + jumpForce, myRB.velocity.z);
            jumpInput = false;
        }
    }
    public void OnMovement(InputAction.CallbackContext context)
    {
        if (context.performed || context.canceled)
        {
            movementInput = context.ReadValue<Vector2>();
        }
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed && transform.position.y < -1.20)
        {
            jumpInput = true;
        }
    }
}
