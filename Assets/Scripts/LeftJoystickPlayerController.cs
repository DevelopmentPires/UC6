﻿using UnityEngine;

public class LeftJoystickPlayerController : MonoBehaviour
{
    public LeftJoystick leftJoystick; // the game object containing the LeftJoystick script
    public Transform rotationTarget; // the game object that will rotate to face the input direction
    public float moveSpeed = 6.0f; // movement speed of the player character
    public int rotationSpeed = 8; // rotation speed of the player character
    public Animator animator; // the animator controller of the player character
    private Vector3 leftJoystickInput; // holds the input of the Left Joystick
    private CharacterController charControl; // rigid body component of the player character

    void Start()
    {
        if (transform.GetComponent<CharacterController>() == null)
        {
            Debug.LogError("There is no a Character COntroller joinned with the Player!");
        }
        else
        {
            charControl = transform.GetComponent<CharacterController>();
        }

        if (leftJoystick == null)
        {
            Debug.LogError("The left joystick is not attached.");
        }

        if (rotationTarget == null)
        {
            Debug.LogError("The target rotation game object is not attached.");
        }
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        // get input from both joysticks
        leftJoystickInput = leftJoystick.GetInputDirection();

        float xMovementLeftJoystick = leftJoystickInput.x; // The horizontal movement from joystick 01
        float zMovementLeftJoystick = leftJoystickInput.y; // The vertical movement from joystick 01	

        // if there is no input on the left joystick
        if (leftJoystickInput == Vector3.zero)
        {
 //           animator.SetBool("isRunning", false);
        }
  
        // if there is only input from the left joystick
        if (leftJoystickInput != Vector3.zero)
        {
            // calculate the player's direction based on angle
            float tempAngle = Mathf.Atan2(zMovementLeftJoystick, xMovementLeftJoystick);
            xMovementLeftJoystick *= Mathf.Abs(Mathf.Cos(tempAngle));
            zMovementLeftJoystick *= Mathf.Abs(Mathf.Sin(tempAngle));

            leftJoystickInput = new Vector3(xMovementLeftJoystick, 0, zMovementLeftJoystick);
            leftJoystickInput = transform.TransformDirection(leftJoystickInput);
            leftJoystickInput *= moveSpeed;

            // rotate the player to face the direction of input
            Vector3 temp = transform.position;
            temp.x += xMovementLeftJoystick;
            temp.z += zMovementLeftJoystick;
            Vector3 lookDirection = temp - transform.position;
            if (lookDirection != Vector3.zero)
            {
                //    rotationTarget.localRotation = Quaternion.Slerp(rotationTarget.localRotation, Quaternion.LookRotation(lookDirection), rotationSpeed * Time.deltaTime);
               transform.Rotate(new Vector3(0, xMovementLeftJoystick * rotationSpeed * Time.deltaTime, 0));
            }
            if (animator != null)
            {
 //               animator.SetBool("isRunning", true);
            }

            // move the player
            Vector3 move = zMovementLeftJoystick * transform.TransformDirection(Vector3.forward) * moveSpeed;
            charControl.Move(move * Time.fixedDeltaTime);
        }
    }
}