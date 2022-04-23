using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;
using Mirror;
using Mirror.Discovery;
using Mirror.Authenticators;
using Mirror.RemoteCalls;
using Cinemachine;

public class InputManager : NetworkBehaviour
{

    [SerializeField] Movement movement;
    [SerializeField] MouseLook mouseLook;
    [SerializeField] PlayerHealth playerHealth;

    [SerializeField] GameObject gun;
    Shooting shooting;

    [SerializeField] CinemachineVirtualCamera virtualCamera = null;

    PlayerInputController PIC;
    PlayerInputController.GroundMovementActions GroundMovement;
    PlayerInputController.CameraMovementActions CameraMovement;
    PlayerInputController.ShootingActions ShootingAction;
    PlayerInputController.QuickActionsActions QuickActions;

    Vector2 horizontalInput;
    Vector2 mouseInput;

    private void Awake()
    {

        shooting = gun.GetComponent<Shooting>();

        PIC = new PlayerInputController();
        GroundMovement = PIC.GroundMovement;
        CameraMovement = PIC.CameraMovement;
        ShootingAction = PIC.Shooting;
        QuickActions = PIC.QuickActions;

        GroundMovement.HorizontalMovement.performed += ctx => horizontalInput = ctx.ReadValue<Vector2>();
        GroundMovement.Jump.performed += _ => movement.OnJumpPressed();
        GroundMovement.Crouch.performed += _ => movement.CrouchOn();
        GroundMovement.Crouch.canceled += _ => movement.CrouchOff();
        GroundMovement.Run.performed += _ => movement.RunOn();
        GroundMovement.Run.canceled += _ => movement.RunOff();

        CameraMovement.Look.performed += ctx => mouseInput = ctx.ReadValue<Vector2>();

        ShootingAction.Shoot.performed += _ => shooting.Hold();
        ShootingAction.Shoot.canceled += _ => shooting.Release();
        ShootingAction.ChangeMode.performed += _ => shooting.ChangeMode();
        ShootingAction.Reload.performed += _ => shooting.Reload();

        QuickActions.QuickHeal.performed += ctx => {
            if (ctx.interaction is HoldInteraction)
            {
                playerHealth.QuickHeal();
            }
        };
    }

    public override void OnStartAuthority()
    {
        virtualCamera.gameObject.SetActive(true);
        enabled = true;
    }

    [Client]
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


