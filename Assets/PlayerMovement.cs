using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //variables
    public float moveSpeed;
    public Rigidbody2D body;
    private Vector2 moveDirection;
    public InputActionReference move;
    public InputActionReference jump;
    public InputActionReference close;
    public float jumpStrength = 5f;
    


    void Start()
    {

    }

    void Update()
    {
        movement();
    }


    //handles player movement
    void movement()
    {
        //left to right movement, reads the input and passes it into move direction which determines left or right, and multiplies by move speed. 
        moveDirection = move.action.ReadValue<Vector2>();
        body.linearVelocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y*moveSpeed);




        //jump
        jump.action.started += Jump;

        //close game
        close.action.started += Close;

    }

    //currently tests, runs when the buttons are pressed. 
    private void Jump(InputAction.CallbackContext obj)
    {
        Debug.Log("jump");
    }
    private void Close(InputAction.CallbackContext obj)
    {
        Debug.Log("close game");
    }
}
