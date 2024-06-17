using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 2.0f; // Adjusted move speed
    public InputAction LeftAction;
    public InputAction RightAction;
    public InputAction UpAction;
    public InputAction DownAction;

    // Start is called before the first frame update
    void Start()
    {
        LeftAction.Enable();
        RightAction.Enable();
        UpAction.Enable();
        DownAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // Initialize the movement vector
        Vector2 move = Vector2.zero;

        // Determine the movement direction based on input
        if (LeftAction.IsPressed())
        {
            move.x = -1f;
        }
        else if (RightAction.IsPressed())
        {
            move.x = 1f;
        }

        if (UpAction.IsPressed())
        {
            move.y = 1f;
        }
        else if (DownAction.IsPressed())
        {
            move.y = -1f;
        }

        // Normalize the movement vector to prevent faster diagonal movement
        if (move != Vector2.zero)
        {
            move.Normalize();
        }

        // Apply the movement to the position with Time.deltaTime to ensure frame-rate independent movement
        transform.position += (Vector3)move * moveSpeed * Time.deltaTime;
    }
}
