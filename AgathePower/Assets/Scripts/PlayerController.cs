using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 0.01f;
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
        // declare a new float variable called horizontal and sets its value to 0.0
        float horizontal = 0.0f;
        // walk to the left by pressing the in the Inspector defined Key
        if (LeftAction.IsPressed())
        {
            horizontal = -moveSpeed;
        }
        // walk to the right by pressing the in the Inspector defined Key
        else if (RightAction.IsPressed())
        {
            horizontal = moveSpeed;
        }
        // declare a new float variable called vertical and sets its value to 0.0
        float vertical = 0.0f;
        // walk up by pressing the in the Inspector defined Key
        if (UpAction.IsPressed())
        {
            vertical = moveSpeed;
        }
        // walk down by pressing the in the Inspector defined Key
        else if (DownAction.IsPressed())
        {
            vertical = -moveSpeed;
        }
        //store the current position of the GameObject
        Vector2 position = transform.position;
        //set a new horizontal (x-axis)/ vertical (y-axis) position for the GameObject
        position.x = position.x + 0.1f * horizontal;
        position.y = position.y + 0.1f * vertical;
        //set the Position property in the Transform component using your position variable
        transform.position = position;
    }
}
