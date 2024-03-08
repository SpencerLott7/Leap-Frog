using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class Player2Input : MonoBehaviour
{
    public float speed;
    public float rotationSpeed = 90;
    public float gravity = -20f;
    public float jumpSpeed = 14;

    CharacterController characterController;
    Vector3 moveVelocity;
    Vector3 turnVelocity;
    void Start()
    {
         characterController = GetComponent<CharacterController>();
         speed=8;
    }

    // Update is called once per frame
    void Update()
    {
        var hInput = Input.GetAxis("Horizontal2");
        var vInput = Input.GetAxis("Vertical2");
        if(characterController.isGrounded)
        {
            moveVelocity = transform.forward * speed * vInput;
            turnVelocity = transform.up * rotationSpeed * hInput;
                if(Input.GetButtonDown("Jump2"))
                {
                    moveVelocity.y = jumpSpeed;
                }
        }
        //Adding gravity
        moveVelocity.y += gravity * Time.deltaTime;
        characterController.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(turnVelocity * Time.deltaTime);
    }
    public void AppleSpeed()
    {
        Debug.Log("Yup");
    }
}
