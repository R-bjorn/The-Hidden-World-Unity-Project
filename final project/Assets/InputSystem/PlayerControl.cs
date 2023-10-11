// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/PlayerControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""db671490-0597-470d-8801-ce45eba8057c"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b35b758d-0ec3-46ec-a52d-eb3faa358578"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""c4dfd419-abb3-4434-997c-cc1efab9c729"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""1e831b63-a831-47a8-b335-ef50a43a5157"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b6c6c3e0-d5a5-42fc-ad04-b91b44e2e693"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d6717717-29f9-4af3-a01b-f3c382668c61"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e9832f25-ad47-44cc-a67b-d2db9ab3b3a8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""17fb76b9-c05e-43d0-aaee-1e64b98a99c4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""23144621-7ddb-4e1d-aa6d-f7ee5e755876"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a52eff81-22a0-4233-bb09-4d141a856749"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fd314f8b-5e07-4e28-be04-8890b111af2a"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Dance"",
            ""id"": ""913b2f82-26dd-445b-8249-0ea0f7c1767a"",
            ""actions"": [
                {
                    ""name"": ""BDayDance"",
                    ""type"": ""Button"",
                    ""id"": ""a650fb57-82a0-4c5e-99a8-ac8dac6754c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SillyDance"",
                    ""type"": ""Value"",
                    ""id"": ""111026ce-1a8b-4349-97ec-a0b3a77067fa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""RobotDance"",
                    ""type"": ""Button"",
                    ""id"": ""726cb200-1d39-46dc-a86f-dcbd29c74441"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""BUpDance"",
                    ""type"": ""Button"",
                    ""id"": ""43c459b0-0b5a-4215-844d-443b09d9bf60"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Shift+2"",
                    ""id"": ""8394fbc6-c831-48c4-b67f-9b8b44d8be93"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SillyDance"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""2c0aef4b-75eb-4901-9cf2-a5894ef91245"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SillyDance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""df454d2d-fe5b-4b38-b3b3-f92a103d52f2"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SillyDance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Shift+3"",
                    ""id"": ""93a1d74f-4e1d-4ff8-8145-a4c4fac0b8b4"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RobotDance"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""91bcfd47-2c23-4874-b3bd-8b9eabcf5dc9"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RobotDance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""c06797e8-1557-4164-8bb6-505eec27d8f0"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RobotDance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Shift+4"",
                    ""id"": ""a4e2fcee-fd8c-48c7-9c72-2ed5922eb625"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BUpDance"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""63684796-8e31-4a4f-b542-be15471b0e17"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BUpDance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""4bd41dc5-eab9-4307-9f10-30c86173b2b9"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BUpDance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Shift+1"",
                    ""id"": ""ff92528e-2fb6-4ce6-a91c-0a21e35f813d"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BDayDance"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""68ee053f-bcd0-46a9-b8ca-f9c5c235ebb2"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BDayDance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""590b0915-90c9-4ef4-a1b9-1930be76a4d9"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BDayDance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Run = m_Player.FindAction("Run", throwIfNotFound: true);
        // Dance
        m_Dance = asset.FindActionMap("Dance", throwIfNotFound: true);
        m_Dance_BDayDance = m_Dance.FindAction("BDayDance", throwIfNotFound: true);
        m_Dance_SillyDance = m_Dance.FindAction("SillyDance", throwIfNotFound: true);
        m_Dance_RobotDance = m_Dance.FindAction("RobotDance", throwIfNotFound: true);
        m_Dance_BUpDance = m_Dance.FindAction("BUpDance", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Run;
    public struct PlayerActions
    {
        private @PlayerControl m_Wrapper;
        public PlayerActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Run => m_Wrapper.m_Player_Run;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Run.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Dance
    private readonly InputActionMap m_Dance;
    private IDanceActions m_DanceActionsCallbackInterface;
    private readonly InputAction m_Dance_BDayDance;
    private readonly InputAction m_Dance_SillyDance;
    private readonly InputAction m_Dance_RobotDance;
    private readonly InputAction m_Dance_BUpDance;
    public struct DanceActions
    {
        private @PlayerControl m_Wrapper;
        public DanceActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @BDayDance => m_Wrapper.m_Dance_BDayDance;
        public InputAction @SillyDance => m_Wrapper.m_Dance_SillyDance;
        public InputAction @RobotDance => m_Wrapper.m_Dance_RobotDance;
        public InputAction @BUpDance => m_Wrapper.m_Dance_BUpDance;
        public InputActionMap Get() { return m_Wrapper.m_Dance; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DanceActions set) { return set.Get(); }
        public void SetCallbacks(IDanceActions instance)
        {
            if (m_Wrapper.m_DanceActionsCallbackInterface != null)
            {
                @BDayDance.started -= m_Wrapper.m_DanceActionsCallbackInterface.OnBDayDance;
                @BDayDance.performed -= m_Wrapper.m_DanceActionsCallbackInterface.OnBDayDance;
                @BDayDance.canceled -= m_Wrapper.m_DanceActionsCallbackInterface.OnBDayDance;
                @SillyDance.started -= m_Wrapper.m_DanceActionsCallbackInterface.OnSillyDance;
                @SillyDance.performed -= m_Wrapper.m_DanceActionsCallbackInterface.OnSillyDance;
                @SillyDance.canceled -= m_Wrapper.m_DanceActionsCallbackInterface.OnSillyDance;
                @RobotDance.started -= m_Wrapper.m_DanceActionsCallbackInterface.OnRobotDance;
                @RobotDance.performed -= m_Wrapper.m_DanceActionsCallbackInterface.OnRobotDance;
                @RobotDance.canceled -= m_Wrapper.m_DanceActionsCallbackInterface.OnRobotDance;
                @BUpDance.started -= m_Wrapper.m_DanceActionsCallbackInterface.OnBUpDance;
                @BUpDance.performed -= m_Wrapper.m_DanceActionsCallbackInterface.OnBUpDance;
                @BUpDance.canceled -= m_Wrapper.m_DanceActionsCallbackInterface.OnBUpDance;
            }
            m_Wrapper.m_DanceActionsCallbackInterface = instance;
            if (instance != null)
            {
                @BDayDance.started += instance.OnBDayDance;
                @BDayDance.performed += instance.OnBDayDance;
                @BDayDance.canceled += instance.OnBDayDance;
                @SillyDance.started += instance.OnSillyDance;
                @SillyDance.performed += instance.OnSillyDance;
                @SillyDance.canceled += instance.OnSillyDance;
                @RobotDance.started += instance.OnRobotDance;
                @RobotDance.performed += instance.OnRobotDance;
                @RobotDance.canceled += instance.OnRobotDance;
                @BUpDance.started += instance.OnBUpDance;
                @BUpDance.performed += instance.OnBUpDance;
                @BUpDance.canceled += instance.OnBUpDance;
            }
        }
    }
    public DanceActions @Dance => new DanceActions(this);
    public interface IPlayerActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
    }
    public interface IDanceActions
    {
        void OnBDayDance(InputAction.CallbackContext context);
        void OnSillyDance(InputAction.CallbackContext context);
        void OnRobotDance(InputAction.CallbackContext context);
        void OnBUpDance(InputAction.CallbackContext context);
    }
}
