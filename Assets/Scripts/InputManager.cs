using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using Mirror.Discovery;
using Mirror.Authenticators;
using Mirror.RemoteCalls;
using Cinemachine;

public class InputManager : NetworkBehaviour
{
    [SerializeField] Movement movement;
    [SerializeField] MouseLook mouseLook;
    [SerializeField] CinemachineVirtualCamera virtualCamera = null;

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

        CameraMovement.Look.performed += ctx => mouseInput = ctx.ReadValue<Vector2>();
    }

    public override void OnStartAuthority()
    {
        virtualCamera.gameObject.SetActive(true);
        enabled = true;
    }

    private void Update()
    {
        if (!hasAuthority) { return; }
        movement.ReceiveInput(horizontalInput);
        mouseLook.ReceiveInput(mouseInput);
    }

    [ClientCallback]
    private void OnEnable()
    {
        PIC.Enable();
    }

    [ClientCallback]
    private void OnDestroy()
    {
        PIC.Disable();
    }

}


