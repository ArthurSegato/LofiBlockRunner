// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/InputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputSystem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystem"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""02ce639d-721f-4493-8c0a-4c8618855a48"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""f894792e-3339-40b0-9145-067529564f32"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""ebb313b8-fed9-4bae-b6a9-895fcb56626b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ebbaf50c-75d4-4d9c-b724-ed72c4efcd33"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""92fd16a1-491e-4aac-8468-8a4250bfa597"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Setas"",
                    ""id"": ""22e993ee-e238-4d2c-bd05-fc7bcb9a99df"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e4bc5e91-1e36-4772-a69a-6dfe55cd567c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""54ce057b-894f-43f9-9430-4412d928e637"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controle / Dpad"",
                    ""id"": ""94f25f24-84fe-4705-9479-1b9ee441d960"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6f623f76-d15c-4bd9-99d6-c555f27fc9bd"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c40aa4cc-5616-4f47-b30a-b058cc93ad76"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controle / LeftSticker"",
                    ""id"": ""30ce8bb1-33af-4955-b640-54ab7af3e2b8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ca49e8e3-b95a-492b-bc01-65c81f913571"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9bae7c5b-80e5-4a7d-ab8a-2ee0dd5cbab5"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controle / RightSticker"",
                    ""id"": ""3bd4cf4d-e800-4d28-99be-ee93e1574fa8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0b31f4a3-47d9-4014-8e36-6e57c11abbd5"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""64aa3b2b-3429-442b-9ce3-3901a11fa1dd"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Interface"",
            ""id"": ""f253133c-2668-405e-a0cb-a475f42f6a2d"",
            ""actions"": [
                {
                    ""name"": ""Left Click"",
                    ""type"": ""Button"",
                    ""id"": ""cd5ab93c-9d1c-4b4f-84bd-a64bbc2726f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""Button"",
                    ""id"": ""d12b1e36-53a2-4f48-972a-ee73b7697f5f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Click"",
                    ""type"": ""Button"",
                    ""id"": ""d289773d-3e56-48d1-8e8c-e61c6ce1c42c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""605563a2-a65e-4aa9-b108-49781bbab5b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b225979d-d8d8-4b4d-9b87-2c64d6dd045d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0820da29-cc10-4a70-bdd9-e2e274e8b7e7"",
                    ""path"": ""<Pointer>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""223b4264-2f1b-4e4f-9a19-4720bd803430"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad8a4303-b027-46dc-9201-d3559a2ec6e9"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
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
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        // Interface
        m_Interface = asset.FindActionMap("Interface", throwIfNotFound: true);
        m_Interface_LeftClick = m_Interface.FindAction("Left Click", throwIfNotFound: true);
        m_Interface_Point = m_Interface.FindAction("Point", throwIfNotFound: true);
        m_Interface_RightClick = m_Interface.FindAction("Right Click", throwIfNotFound: true);
        m_Interface_Click = m_Interface.FindAction("Click", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Movement;
    public struct PlayerActions
    {
        private @InputSystem m_Wrapper;
        public PlayerActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Interface
    private readonly InputActionMap m_Interface;
    private IInterfaceActions m_InterfaceActionsCallbackInterface;
    private readonly InputAction m_Interface_LeftClick;
    private readonly InputAction m_Interface_Point;
    private readonly InputAction m_Interface_RightClick;
    private readonly InputAction m_Interface_Click;
    public struct InterfaceActions
    {
        private @InputSystem m_Wrapper;
        public InterfaceActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftClick => m_Wrapper.m_Interface_LeftClick;
        public InputAction @Point => m_Wrapper.m_Interface_Point;
        public InputAction @RightClick => m_Wrapper.m_Interface_RightClick;
        public InputAction @Click => m_Wrapper.m_Interface_Click;
        public InputActionMap Get() { return m_Wrapper.m_Interface; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InterfaceActions set) { return set.Get(); }
        public void SetCallbacks(IInterfaceActions instance)
        {
            if (m_Wrapper.m_InterfaceActionsCallbackInterface != null)
            {
                @LeftClick.started -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnLeftClick;
                @Point.started -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnPoint;
                @RightClick.started -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnRightClick;
                @Click.started -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_InterfaceActionsCallbackInterface.OnClick;
            }
            m_Wrapper.m_InterfaceActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
            }
        }
    }
    public InterfaceActions @Interface => new InterfaceActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IInterfaceActions
    {
        void OnLeftClick(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
    }
}
