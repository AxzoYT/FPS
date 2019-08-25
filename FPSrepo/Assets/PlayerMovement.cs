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


    public float playerMovementSpeed;


    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Debug.Log(Input.mousePosition);




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
    }
}