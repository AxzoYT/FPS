using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody playerRB;

    public KeyCode strafeLeft = KeyCode.A;
    public KeyCode strafeRight = KeyCode.D;
    public KeyCode moveForward = KeyCode.W;
    public KeyCode moveBackward = KeyCode.S;
    public KeyCode Jump = KeyCode.Space;


    public float playerMovementSpeed;
    public float jumpPower;


    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Debug.Log(Input.mousePosition);


        if (Input.mousePresent)
        {
            transform.RotateAround(playerRB.position, transform.up, Input.GetAxis("Mouse X"));
        }


        Debug.Log(Input.GetAxis("Mouse X"));
        //Debug.Log(Input.GetAxis("Mouse Y"));
        //Debug.Log(Input.GetAxis("Mouse X"));




        if (Input.GetKey(strafeLeft))
        {
            transform.Translate(-playerMovementSpeed, 0, 0);
        }
        if (Input.GetKey(strafeRight))
        {
            transform.Translate(playerMovementSpeed, 0, 0);
        }
        if (Input.GetKey(moveForward))
        {
            transform.Translate(0, 0, playerMovementSpeed);
        }
        if (Input.GetKey(moveBackward))
        {
            transform.Translate(0, 0, -playerMovementSpeed);
        }
        if (Input.GetKeyDown(Jump))
        {
            playerRB.AddRelativeForce(0, jumpPower, 0);
        }

    }

}