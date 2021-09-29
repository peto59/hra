using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] Movement movement;
    [SerializeField] MouseLook mouseLook;

    PlayerInputController PIC;
    PlayerInputController.GroundMovementActions GroundMovement;

    PlayerInputController.CameraMovementActions CameraMovement;

    Vector2 horizontalInput;
    Vector2 mouseInput;

    private void Awake()
    {
        PIC = new PlayerInputController();
        GroundMovement = PIC.GroundMovement;
        CameraMovement = PIC.CameraMovement;

        GroundMovement.HorizontalMovement.performed += ctx => horizontalInput = ctx.ReadValue<Vector2>();
        GroundMovement.Jump.performed += _ => movement.OnJumpPressed();

        CameraMovement.LookX.performed += ctx => mouseInput.x = ctx.ReadValue<float>();
        CameraMovement.LookY.performed += ctx => mouseInput.y = ctx.ReadValue<float>();
    }

    private void Update()
    {
        //Debug.Log(inputLook);
        movement.ReceiveInput(horizontalInput);
        mouseLook.ReceiveInput(mouseInput);
    }

    private void OnEnable()
    {
        PIC.Enable();
    }

    private void OnDestroy()
    {
        PIC.Disable();
    }

}


