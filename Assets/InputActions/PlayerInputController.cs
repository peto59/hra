// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/PlayerInputController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputController"",
    ""maps"": [
        {
            ""name"": ""GroundMovement"",
            ""id"": ""82d8f81a-3d55-4cd2-bfe2-bdbb8b0db7c0"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""17c9acb1-2ca6-4244-ba91-6e13ae84fd57"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""65ef7996-a93f-4a0f-8d61-75b1eeb75dcd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""68b1a5e3-cb54-4f33-8e54-b4096de81062"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""09d4c929-d6c5-4618-a8f8-d67e2fa95203"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Prone"",
                    ""type"": ""Button"",
                    ""id"": ""465d4a8d-6d15-49ac-8ba1-b97e6502d2e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""033e2f68-764c-46ac-bcae-988e7c25f3e6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""868d5aa2-32bc-4355-877a-67c6e1b3351b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5f5c84fe-8e8e-4619-845a-5f8031f0ef87"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""452d7100-52ea-466b-b108-5ea019058aff"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b684f5a2-a795-4a9f-ac53-c906b80bdb39"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""24db678d-817e-4436-8a18-4ae29f1a8c06"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68038afa-eaaf-4d70-85b0-edefe56dc800"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af9bdd0b-7009-4626-a9d9-b02d6f8723c3"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c830090-ccba-4d1f-9d5b-26e76640f5d9"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Prone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CameraMovement"",
            ""id"": ""4532f000-d1ae-4c01-b9e3-ed7faf70fcf3"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fb746852-4c62-4fac-b0e9-67830705af28"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7a3dfda4-c4c7-4dfb-be5e-7c8879e255a6"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Shooting"",
            ""id"": ""3d26a4c5-4b7d-4b97-95bc-84aa29c35147"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""1a2a54ee-f849-4ca0-9dbc-44a23936ac2f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeMode"",
                    ""type"": ""Button"",
                    ""id"": ""c13258b4-348d-43b5-8a57-e604a47bb734"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""b35f900c-ef9a-4bb0-aaba-5261c7c63a10"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Button"",
                    ""id"": ""09408734-82c0-4b1a-9c78-fa41e548689e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5ccdc5a9-3a08-4469-9bd1-6de6ecbd944d"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d360de1-1b35-4fc0-8a95-1285229877a4"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61bd004f-24e7-4cf0-8956-097e732284e2"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d0996c8-e45e-4ddd-b58b-72a884d8a367"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""QuickActions"",
            ""id"": ""51cb8bf4-fe77-419d-8d3c-7eaea5393a10"",
            ""actions"": [
                {
                    ""name"": ""QuickHeal"",
                    ""type"": ""Button"",
                    ""id"": ""fc6006f2-a2a0-433a-81df-f43ce8ce08ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.5)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""528921ca-df2e-4996-bcd3-65334ebd0bfc"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""QuickHeal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GroundMovement
        m_GroundMovement = asset.FindActionMap("GroundMovement", throwIfNotFound: true);
        m_GroundMovement_HorizontalMovement = m_GroundMovement.FindAction("HorizontalMovement", throwIfNotFound: true);
        m_GroundMovement_Jump = m_GroundMovement.FindAction("Jump", throwIfNotFound: true);
        m_GroundMovement_Crouch = m_GroundMovement.FindAction("Crouch", throwIfNotFound: true);
        m_GroundMovement_Run = m_GroundMovement.FindAction("Run", throwIfNotFound: true);
        m_GroundMovement_Prone = m_GroundMovement.FindAction("Prone", throwIfNotFound: true);
        // CameraMovement
        m_CameraMovement = asset.FindActionMap("CameraMovement", throwIfNotFound: true);
        m_CameraMovement_Look = m_CameraMovement.FindAction("Look", throwIfNotFound: true);
        // Shooting
        m_Shooting = asset.FindActionMap("Shooting", throwIfNotFound: true);
        m_Shooting_Shoot = m_Shooting.FindAction("Shoot", throwIfNotFound: true);
        m_Shooting_ChangeMode = m_Shooting.FindAction("ChangeMode", throwIfNotFound: true);
        m_Shooting_Reload = m_Shooting.FindAction("Reload", throwIfNotFound: true);
        m_Shooting_Zoom = m_Shooting.FindAction("Zoom", throwIfNotFound: true);
        // QuickActions
        m_QuickActions = asset.FindActionMap("QuickActions", throwIfNotFound: true);
        m_QuickActions_QuickHeal = m_QuickActions.FindAction("QuickHeal", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // GroundMovement
    private readonly InputActionMap m_GroundMovement;
    private IGroundMovementActions m_GroundMovementActionsCallbackInterface;
    private readonly InputAction m_GroundMovement_HorizontalMovement;
    private readonly InputAction m_GroundMovement_Jump;
    private readonly InputAction m_GroundMovement_Crouch;
    private readonly InputAction m_GroundMovement_Run;
    private readonly InputAction m_GroundMovement_Prone;
    public struct GroundMovementActions
    {
        private @PlayerInputController m_Wrapper;
        public GroundMovementActions(@PlayerInputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_GroundMovement_HorizontalMovement;
        public InputAction @Jump => m_Wrapper.m_GroundMovement_Jump;
        public InputAction @Crouch => m_Wrapper.m_GroundMovement_Crouch;
        public InputAction @Run => m_Wrapper.m_GroundMovement_Run;
        public InputAction @Prone => m_Wrapper.m_GroundMovement_Prone;
        public InputActionMap Get() { return m_Wrapper.m_GroundMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GroundMovementActions set) { return set.Get(); }
        public void SetCallbacks(IGroundMovementActions instance)
        {
            if (m_Wrapper.m_GroundMovementActionsCallbackInterface != null)
            {
                @HorizontalMovement.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnHorizontalMovement;
                @Jump.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnCrouch;
                @Run.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnRun;
                @Prone.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnProne;
                @Prone.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnProne;
                @Prone.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnProne;
            }
            m_Wrapper.m_GroundMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Prone.started += instance.OnProne;
                @Prone.performed += instance.OnProne;
                @Prone.canceled += instance.OnProne;
            }
        }
    }
    public GroundMovementActions @GroundMovement => new GroundMovementActions(this);

    // CameraMovement
    private readonly InputActionMap m_CameraMovement;
    private ICameraMovementActions m_CameraMovementActionsCallbackInterface;
    private readonly InputAction m_CameraMovement_Look;
    public struct CameraMovementActions
    {
        private @PlayerInputController m_Wrapper;
        public CameraMovementActions(@PlayerInputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_CameraMovement_Look;
        public InputActionMap Get() { return m_Wrapper.m_CameraMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraMovementActions set) { return set.Get(); }
        public void SetCallbacks(ICameraMovementActions instance)
        {
            if (m_Wrapper.m_CameraMovementActionsCallbackInterface != null)
            {
                @Look.started -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_CameraMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public CameraMovementActions @CameraMovement => new CameraMovementActions(this);

    // Shooting
    private readonly InputActionMap m_Shooting;
    private IShootingActions m_ShootingActionsCallbackInterface;
    private readonly InputAction m_Shooting_Shoot;
    private readonly InputAction m_Shooting_ChangeMode;
    private readonly InputAction m_Shooting_Reload;
    private readonly InputAction m_Shooting_Zoom;
    public struct ShootingActions
    {
        private @PlayerInputController m_Wrapper;
        public ShootingActions(@PlayerInputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_Shooting_Shoot;
        public InputAction @ChangeMode => m_Wrapper.m_Shooting_ChangeMode;
        public InputAction @Reload => m_Wrapper.m_Shooting_Reload;
        public InputAction @Zoom => m_Wrapper.m_Shooting_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_Shooting; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShootingActions set) { return set.Get(); }
        public void SetCallbacks(IShootingActions instance)
        {
            if (m_Wrapper.m_ShootingActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_ShootingActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_ShootingActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_ShootingActionsCallbackInterface.OnShoot;
                @ChangeMode.started -= m_Wrapper.m_ShootingActionsCallbackInterface.OnChangeMode;
                @ChangeMode.performed -= m_Wrapper.m_ShootingActionsCallbackInterface.OnChangeMode;
                @ChangeMode.canceled -= m_Wrapper.m_ShootingActionsCallbackInterface.OnChangeMode;
                @Reload.started -= m_Wrapper.m_ShootingActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_ShootingActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_ShootingActionsCallbackInterface.OnReload;
                @Zoom.started -= m_Wrapper.m_ShootingActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_ShootingActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_ShootingActionsCallbackInterface.OnZoom;
            }
            m_Wrapper.m_ShootingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @ChangeMode.started += instance.OnChangeMode;
                @ChangeMode.performed += instance.OnChangeMode;
                @ChangeMode.canceled += instance.OnChangeMode;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
            }
        }
    }
    public ShootingActions @Shooting => new ShootingActions(this);

    // QuickActions
    private readonly InputActionMap m_QuickActions;
    private IQuickActionsActions m_QuickActionsActionsCallbackInterface;
    private readonly InputAction m_QuickActions_QuickHeal;
    public struct QuickActionsActions
    {
        private @PlayerInputController m_Wrapper;
        public QuickActionsActions(@PlayerInputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @QuickHeal => m_Wrapper.m_QuickActions_QuickHeal;
        public InputActionMap Get() { return m_Wrapper.m_QuickActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(QuickActionsActions set) { return set.Get(); }
        public void SetCallbacks(IQuickActionsActions instance)
        {
            if (m_Wrapper.m_QuickActionsActionsCallbackInterface != null)
            {
                @QuickHeal.started -= m_Wrapper.m_QuickActionsActionsCallbackInterface.OnQuickHeal;
                @QuickHeal.performed -= m_Wrapper.m_QuickActionsActionsCallbackInterface.OnQuickHeal;
                @QuickHeal.canceled -= m_Wrapper.m_QuickActionsActionsCallbackInterface.OnQuickHeal;
            }
            m_Wrapper.m_QuickActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @QuickHeal.started += instance.OnQuickHeal;
                @QuickHeal.performed += instance.OnQuickHeal;
                @QuickHeal.canceled += instance.OnQuickHeal;
            }
        }
    }
    public QuickActionsActions @QuickActions => new QuickActionsActions(this);
    public interface IGroundMovementActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnProne(InputAction.CallbackContext context);
    }
    public interface ICameraMovementActions
    {
        void OnLook(InputAction.CallbackContext context);
    }
    public interface IShootingActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnChangeMode(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
    }
    public interface IQuickActionsActions
    {
        void OnQuickHeal(InputAction.CallbackContext context);
    }
}
