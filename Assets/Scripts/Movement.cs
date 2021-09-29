using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 11f;

    Vector2 horizontalInput;

    [SerializeField] float gravity = -10f;
    [SerializeField] Vector3 verticalVelocity = Vector3.zero;

    [SerializeField] float jumpHeight = 3.5f;
    bool jump;

    private void Update()
    {
        if (controller.isGrounded)
        {
            verticalVelocity.y = 0;
            if (jump)
            {
                verticalVelocity.y = Mathf.Sqrt(-2 * jumpHeight * gravity);
            }
            jump = false;
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
}
