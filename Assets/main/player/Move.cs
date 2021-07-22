using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class Move : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed = 2.0f;
    public float jumpHeight = 5.0f;
    public float gravityValue = -9.81f;
    private PlayerInput PlayerInput;

    public bool attak;

    public GameObject[] fillContainers;
    public GameObject[] emptyContainers;

    public GameObject empty;
    public GameObject fill;

    public int maxCurrentHearts;
    public int currentHearts;
    public int maxHearts;

    private void Start()
    {
        PlayerInput = gameObject.GetComponent<PlayerInput>();
        controller = gameObject.GetComponent<CharacterController>();

        for (int i = 0; i < maxHearts; i++)
        {
            fillContainers[i] = fill.transform.GetChild(i).gameObject;

            if (i < maxHearts / 2)
            {
                emptyContainers[i] = empty.transform.GetChild(i).gameObject;
            }
        }



        /*spawn hearts in UI*/
        for (int i = 0; i < maxCurrentHearts; i++)
        {
            if (i < currentHearts)
            {
                fillContainers[i].GetComponent<Image>().enabled = true;
            }

            if (i < maxCurrentHearts / 2)
            {
                emptyContainers[i].GetComponent<Image>().enabled = true;
            }
        }
        /*spawn hearts in UI*/

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
        
        if (attak)
        {
            takeDamage();
        }

    }

    public void takeDamage()
    {
        currentHearts -= 1;
        attak = false;
        if (currentHearts == 0)
        {
            fillContainers[currentHearts].GetComponent<Image>().enabled = false;
            /*dead();*/
        }
        else
        {
            fillContainers[currentHearts].GetComponent<Image>().enabled = false;
        }
        
        
    }

}
