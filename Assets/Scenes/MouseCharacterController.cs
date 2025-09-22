using UnityEngine;
using UnityEngine.InputSystem;

public class MouseCharacterController : MonoBehaviour
{
    

    public float speed = 5f; 

    [Header("Input")]
    public PlayerInput playerInput;
    private Vector3 inputDirection;
    private bool currentInput = false;

    void Update()
    {
        CalculateMovementInput();
    }
    void FixedUpdate()
    {
        MoveThePlayer();
    }

    void CalculateMovementInput()
    {
        if (inputDirection == Vector3.zero)
        {
            currentInput = false;
        }
        else if (inputDirection != Vector3.zero)
        {
            currentInput = true;
        }
    }

    void MoveThePlayer()
    {
        if (currentInput == true)
        {
            Vector3 movement = inputDirection.normalized * speed * Time.deltaTime;
            transform.position += (movement * Time.deltaTime * speed);
        }

    }

    public void OnMove(InputValue value)
    {
        inputDirection = value.Get<Vector2>();
    }

}