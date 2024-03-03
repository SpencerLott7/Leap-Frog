using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerInput : MonoBehaviour
{
    public float speed ;
    public float rotationSpeed = 90;
    public float gravity = -20f;
    public float jumpSpeed = 20;

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
        var hInput = Input.GetAxis("Horizontal");
        var vInput = Input.GetAxis("Vertical");
        if(characterController.isGrounded)
        {
        moveVelocity = transform.forward * speed * vInput;
        turnVelocity = transform.up * rotationSpeed * hInput;
        if(Input.GetButtonDown("Jump") && Managers.Player.jumpCount>=1)
        {
        moveVelocity.y = jumpSpeed;
        Managers.Player.addJump(-1);
    
        }
        }
        //Adding gravity
        moveVelocity.y += gravity * Time.deltaTime;
        characterController.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(turnVelocity * Time.deltaTime);
    }
    public void AppleSpeed()
    {
        speed=11;
        Debug.Log("Yup");
    }
}
