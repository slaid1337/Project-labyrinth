using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Move : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed = 2.0f;
    public float jumpHeight = 5.0f;
    public float gravityValue = -9.81f;
    private PlayerInput PlayerInput;


    private void Start()
    {
        PlayerInput = gameObject.GetComponent<PlayerInput>();
        controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;

        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = -1.0f;
        }



        Vector2 input = PlayerInput.actions["Move"].ReadValue<Vector2>();
        Vector3 move = new Vector3(input.x, 0, input.y);
        controller.Move(move * Time.deltaTime * playerSpeed);



        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        

        if (groundedPlayer && PlayerInput.actions["jump"].triggered)
        {               
            playerVelocity.y += jumpHeight;
        }

       
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
        
    }

    
}
