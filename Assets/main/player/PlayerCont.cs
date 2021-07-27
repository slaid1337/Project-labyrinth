// GENERATED AUTOMATICALLY FROM 'Assets/main/player/PlayerCont.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerCont : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerCont()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerCont"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""6b285d66-43df-48c4-8b68-114ca8cf99a1"",
            ""actions"": [
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""06bc8ffd-6301-472a-afc8-94e7d1f27f48"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""e1090109-648d-40ed-b6fa-cb6a59d5404e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""hit"",
                    ""type"": ""Button"",
                    ""id"": ""10382e31-78fd-445e-a3f4-a02e9eca6667"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""shield"",
                    ""type"": ""Button"",
                    ""id"": ""7e29965d-9672-4b0e-b8f6-4ee3858f62b8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0af51edf-b9d9-4bd9-aab8-da6a5d55918a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51af1347-7dc4-48a3-bd8e-e6866b03077c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a728237-d25e-4a7d-9336-f564ceb9ea1d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3d7816e-cb4d-4518-b78c-0e75b271c62a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""hit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d47f6e9-5a96-4068-81f6-91fdd102fee3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""hit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""396216bd-0c76-4157-9f97-d3448b4ba762"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""shield"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c75de5ab-dc30-4e12-bd3a-42b19f0aac2e"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""shield"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_jump = m_Player.FindAction("jump", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_hit = m_Player.FindAction("hit", throwIfNotFound: true);
        m_Player_shield = m_Player.FindAction("shield", throwIfNotFound: true);
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
    private readonly InputAction m_Player_jump;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_hit;
    private readonly InputAction m_Player_shield;
    public struct PlayerActions
    {
        private @PlayerCont m_Wrapper;
        public PlayerActions(@PlayerCont wrapper) { m_Wrapper = wrapper; }
        public InputAction @jump => m_Wrapper.m_Player_jump;
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @hit => m_Wrapper.m_Player_hit;
        public InputAction @shield => m_Wrapper.m_Player_shield;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @hit.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHit;
                @hit.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHit;
                @hit.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHit;
                @shield.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShield;
                @shield.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShield;
                @shield.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShield;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @hit.started += instance.OnHit;
                @hit.performed += instance.OnHit;
                @hit.canceled += instance.OnHit;
                @shield.started += instance.OnShield;
                @shield.performed += instance.OnShield;
                @shield.canceled += instance.OnShield;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnHit(InputAction.CallbackContext context);
        void OnShield(InputAction.CallbackContext context);
    }
}
