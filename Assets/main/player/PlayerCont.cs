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
                },
                {
                    ""name"": ""Bow"",
                    ""type"": ""Button"",
                    ""id"": ""09d1272a-b702-418d-8afd-d0e16c13341e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""0cf69a14-9b79-440a-b6d9-624f84586418"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Water"",
                    ""type"": ""Button"",
                    ""id"": ""df0b4428-1d48-4aef-9dec-bb495509b475"",
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
                    ""path"": ""<Keyboard>/f"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""5210a424-92b5-4243-9138-b0b8a87a7014"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10845a53-e84c-415a-8ab8-777d5b2ea0aa"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""756a08c7-7572-480b-818f-8f1d28641c66"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac762fda-83d3-4ae0-9563-1b9bcb515c59"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3429a9da-4b30-4924-b703-0252c80407f6"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Water"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee9c9e3f-7b61-4e83-8440-b0ef411e3ebd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Water"",
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
        m_Player_Bow = m_Player.FindAction("Bow", throwIfNotFound: true);
        m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
        m_Player_Water = m_Player.FindAction("Water", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Bow;
    private readonly InputAction m_Player_Fire;
    private readonly InputAction m_Player_Water;
    public struct PlayerActions
    {
        private @PlayerCont m_Wrapper;
        public PlayerActions(@PlayerCont wrapper) { m_Wrapper = wrapper; }
        public InputAction @jump => m_Wrapper.m_Player_jump;
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @hit => m_Wrapper.m_Player_hit;
        public InputAction @shield => m_Wrapper.m_Player_shield;
        public InputAction @Bow => m_Wrapper.m_Player_Bow;
        public InputAction @Fire => m_Wrapper.m_Player_Fire;
        public InputAction @Water => m_Wrapper.m_Player_Water;
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
                @Bow.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBow;
                @Bow.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBow;
                @Bow.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBow;
                @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Water.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWater;
                @Water.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWater;
                @Water.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWater;
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
                @Bow.started += instance.OnBow;
                @Bow.performed += instance.OnBow;
                @Bow.canceled += instance.OnBow;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Water.started += instance.OnWater;
                @Water.performed += instance.OnWater;
                @Water.canceled += instance.OnWater;
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
        void OnBow(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnWater(InputAction.CallbackContext context);
    }
}
