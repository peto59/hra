using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Mirror;

public class Movement : NetworkBehaviour
{

    [SerializeField] CharacterController controller;
    [SerializeField] PlayerHealth playerHealth;

    float originalHeight;
    [SerializeField] float crouchHeight = 1f;

    [SerializeField] float originalSpeed = 11f;
    [SerializeField] float speed;
    [SerializeField] float sprintingSpeed = 2f;
    [SerializeField] float crouchingSpeed = 0.5f;

    [SerializeField] float maxStamina = 10f;
    [SerializeField] float stamina;

    Vector2 horizontalInput;

    [SerializeField] float gravity = -10f;
    [SerializeField] Vector3 verticalVelocity = Vector3.zero;
    [SerializeField] float jumpHeight = 3.5f;

    bool jump = false;
    bool crouch = false;
    bool run = false;
    bool running = false;

    float groundedRaycastDistance;
    float distToGround = 0f;

    private void Start()
    {
        groundedRaycastDistance = controller.bounds.extents.y;
        originalHeight = controller.height;
        speed = originalSpeed;
        stamina = maxStamina;
    }

    private void Update()
    {
        
        if (IsGrounded())
        {
            verticalVelocity.y = 0;
            if (jump)
            {
                verticalVelocity.y = Mathf.Sqrt(-2 * jumpHeight * gravity);
            }
            jump = false;
            if(distToGround > 10f)
            {
                int dmg = Convert.ToInt32(distToGround);
                playerHealth.Hit(dmg, "fall");
                print("fall damage");
            }
            distToGround = 0f;
        }
        else
        {
            Physics.Raycast(transform.position, -Vector3.up, out RaycastHit hit, Mathf.Infinity);
            if (hit.distance > distToGround)
            {
                distToGround = hit.distance;
            }
            jump = false;
        }
        
        if (crouch)
        {
            controller.height = Mathf.Clamp(controller.height-(Time.deltaTime*2), crouchHeight, originalHeight);
            groundedRaycastDistance = controller.bounds.extents.y;

        }                                               //raycast to check if we can uncrouch (if something is above us) inverted because if something is above us returns true
        else if (controller.height != originalHeight && !Physics.Raycast(transform.position, Vector3.up, originalHeight - controller.height))
        {
            controller.height = Mathf.Clamp(controller.height + (Time.deltaTime * 2), crouchHeight, originalHeight);
            controller.Move(new Vector3(0, Time.deltaTime * 2, 0));
            groundedRaycastDistance = controller.bounds.extents.y;
        }

        if (run && !crouch && horizontalInput != Vector2.zero)
        {
            if (stamina > maxStamina / 5)
            {
                running = true;
                speed = originalSpeed * sprintingSpeed;
            }
            else
            {
                stamina += Time.deltaTime / 2;
                stamina = Mathf.Clamp(stamina, 0, maxStamina);
            }
            if (running)
            {
                stamina -= Time.deltaTime;
                stamina = Mathf.Clamp(stamina, 0, maxStamina);
            }
            if (stamina == 0)
            {
                running = false;
                speed = originalSpeed;
            }
        }
        else if (stamina < maxStamina)
        {
            if (horizontalInput == Vector2.zero)
            {
                stamina += Time.deltaTime;
                stamina = Mathf.Clamp(stamina, 0, maxStamina);
            }
            else
            {
                stamina += Time.deltaTime / 2;
                stamina = Mathf.Clamp(stamina, 0, maxStamina);
            }
        }

        Vector3 HorizontalVelocity = (transform.right * horizontalInput.x + transform.forward * horizontalInput.y) * speed;
        controller.Move(HorizontalVelocity * Time.deltaTime);

        verticalVelocity.y += gravity * Time.deltaTime;
        controller.Move(verticalVelocity * Time.deltaTime);
    }

    public void ReceiveInput(Vector2 _horizontalInput)
    {
        horizontalInput = _horizontalInput;
    }

    public void OnJumpPressed()
    {
        
        jump = true;
    }

    public void CrouchOn()
    {
        crouch = true;
        speed = originalSpeed * crouchingSpeed;
    }

    public void CrouchOff()
    {
        crouch = false;
        speed = originalSpeed;
    }

    public void RunOn()
    {
        run = true;
    }

    public void RunOff()
    {
        run = false;
        speed = originalSpeed;
    }

    public bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, groundedRaycastDistance + 0.1f);
    }
}
