//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Player.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Player: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""InGamePlayer"",
            ""id"": ""d60ffcb8-4fb7-430e-b968-c4948129b72b"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""bdcd0d27-0035-4829-91c9-37f69d65f4e7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""46e5d6ee-b808-4ae3-9534-0515a15fa3b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""69b3defa-c08b-44be-a46d-17788c81a648"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""9ebfe508-b858-4984-8fe5-1f39c296ab1b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""f136b45c-1de5-4491-a020-e3d66ae8b400"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""7259a5d6-d122-4f2b-82c5-f2835f4f5cd6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""c00a2e8f-47ad-4953-938e-4807bfa23bf1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b748f2a3-091a-41b0-9bce-2ea86083557f"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""a05d05a4-4efc-45d1-8599-f4a702d2188a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f4633c9b-39e9-4837-afb3-ac6a1050ee8f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""99239c25-7edf-4047-86f8-18a8fc56e2e1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f782f622-437b-46a7-85d3-333b16b7c0e4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0ed32e26-fd84-4240-b03b-d0d598e87298"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""79e50061-e6fc-4448-bb42-05ecb18b87c2"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a5895c5-10f1-4ac6-b2d8-1bb2258f44c1"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""295d6456-69e5-4ad3-b5c2-916e11d1c195"",
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
                    ""id"": ""41d4a15b-5c05-4a7a-ad47-f0def36f1955"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84d171e0-47df-4556-ab8a-9d97e3bb3a35"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48fd1d81-ded1-4c1b-865b-480fd38b92dc"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9165f8d-95ca-44bf-ac21-e1a1b8e8ff04"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07a869b8-0780-4ce4-b032-901c8614a353"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""081d2334-f526-465b-9f7d-429700617325"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d74b4429-4ec4-4a0d-9a83-7c98382bf376"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60127ddc-f65f-4271-80c6-a9961a093068"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2585a50-e145-4acb-9afe-c499323435bd"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""59bdf79b-66c6-4dbd-b838-64dc79eee4f8"",
            ""actions"": [
                {
                    ""name"": ""Navigation"",
                    ""type"": ""Value"",
                    ""id"": ""be31c17e-9eba-4f38-902a-539db0c81bf6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Accept"",
                    ""type"": ""Button"",
                    ""id"": ""2d7b6fb4-7446-4806-b2a9-116f1ea44452"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""0d1bf7b5-8758-4f7c-9294-4e5ba4e69e57"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""11a254f3-05ac-4fcd-9710-fce916a3d56d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""0d51e6e1-0b1f-45a4-b752-8dee47cddf48"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""20c79849-d40f-4164-aaef-5d18c746a51a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""54093bb0-0ad8-4caf-8434-d33994ae0b1b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""58c97066-1fc0-451c-b6ed-39ec2b8f506c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4534ae1d-d4be-4ee4-82f8-b34f38b1bc08"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a4905c02-4b04-43f5-a1e7-e7392dca3271"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb9c89c8-16bc-41c1-befe-1013b007be01"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""adcc24dd-fafd-417a-b6c3-64745a1b8f4f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9fa36cd2-53c8-4dab-877a-77d749135e15"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83742fdd-f879-45cf-aac4-96ee6d08bca1"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e584dd1-e551-4b4d-bd0b-407d1a61159f"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Cutscene"",
            ""id"": ""2701b199-d9fe-4ad3-aef8-63e5f3cd7993"",
            ""actions"": [
                {
                    ""name"": ""Skip"",
                    ""type"": ""Button"",
                    ""id"": ""8c37cfe1-3375-4778-92f7-e76d38b2bf32"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""94ed8ff0-88b2-4654-9c04-a71b8d01b06e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb57b82a-20d1-436f-9df2-6050ec8a8578"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // InGamePlayer
        m_InGamePlayer = asset.FindActionMap("InGamePlayer", throwIfNotFound: true);
        m_InGamePlayer_Walk = m_InGamePlayer.FindAction("Walk", throwIfNotFound: true);
        m_InGamePlayer_Sprint = m_InGamePlayer.FindAction("Sprint", throwIfNotFound: true);
        m_InGamePlayer_Crouch = m_InGamePlayer.FindAction("Crouch", throwIfNotFound: true);
        m_InGamePlayer_Look = m_InGamePlayer.FindAction("Look", throwIfNotFound: true);
        m_InGamePlayer_Interact = m_InGamePlayer.FindAction("Interact", throwIfNotFound: true);
        m_InGamePlayer_Pause = m_InGamePlayer.FindAction("Pause", throwIfNotFound: true);
        m_InGamePlayer_Inventory = m_InGamePlayer.FindAction("Inventory", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Navigation = m_UI.FindAction("Navigation", throwIfNotFound: true);
        m_UI_Accept = m_UI.FindAction("Accept", throwIfNotFound: true);
        m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
        // Cutscene
        m_Cutscene = asset.FindActionMap("Cutscene", throwIfNotFound: true);
        m_Cutscene_Skip = m_Cutscene.FindAction("Skip", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // InGamePlayer
    private readonly InputActionMap m_InGamePlayer;
    private List<IInGamePlayerActions> m_InGamePlayerActionsCallbackInterfaces = new List<IInGamePlayerActions>();
    private readonly InputAction m_InGamePlayer_Walk;
    private readonly InputAction m_InGamePlayer_Sprint;
    private readonly InputAction m_InGamePlayer_Crouch;
    private readonly InputAction m_InGamePlayer_Look;
    private readonly InputAction m_InGamePlayer_Interact;
    private readonly InputAction m_InGamePlayer_Pause;
    private readonly InputAction m_InGamePlayer_Inventory;
    public struct InGamePlayerActions
    {
        private @Player m_Wrapper;
        public InGamePlayerActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_InGamePlayer_Walk;
        public InputAction @Sprint => m_Wrapper.m_InGamePlayer_Sprint;
        public InputAction @Crouch => m_Wrapper.m_InGamePlayer_Crouch;
        public InputAction @Look => m_Wrapper.m_InGamePlayer_Look;
        public InputAction @Interact => m_Wrapper.m_InGamePlayer_Interact;
        public InputAction @Pause => m_Wrapper.m_InGamePlayer_Pause;
        public InputAction @Inventory => m_Wrapper.m_InGamePlayer_Inventory;
        public InputActionMap Get() { return m_Wrapper.m_InGamePlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGamePlayerActions set) { return set.Get(); }
        public void AddCallbacks(IInGamePlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_InGamePlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InGamePlayerActionsCallbackInterfaces.Add(instance);
            @Walk.started += instance.OnWalk;
            @Walk.performed += instance.OnWalk;
            @Walk.canceled += instance.OnWalk;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @Crouch.started += instance.OnCrouch;
            @Crouch.performed += instance.OnCrouch;
            @Crouch.canceled += instance.OnCrouch;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
            @Inventory.started += instance.OnInventory;
            @Inventory.performed += instance.OnInventory;
            @Inventory.canceled += instance.OnInventory;
        }

        private void UnregisterCallbacks(IInGamePlayerActions instance)
        {
            @Walk.started -= instance.OnWalk;
            @Walk.performed -= instance.OnWalk;
            @Walk.canceled -= instance.OnWalk;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @Crouch.started -= instance.OnCrouch;
            @Crouch.performed -= instance.OnCrouch;
            @Crouch.canceled -= instance.OnCrouch;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
            @Inventory.started -= instance.OnInventory;
            @Inventory.performed -= instance.OnInventory;
            @Inventory.canceled -= instance.OnInventory;
        }

        public void RemoveCallbacks(IInGamePlayerActions instance)
        {
            if (m_Wrapper.m_InGamePlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInGamePlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_InGamePlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InGamePlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InGamePlayerActions @InGamePlayer => new InGamePlayerActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_Navigation;
    private readonly InputAction m_UI_Accept;
    private readonly InputAction m_UI_Cancel;
    public struct UIActions
    {
        private @Player m_Wrapper;
        public UIActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigation => m_Wrapper.m_UI_Navigation;
        public InputAction @Accept => m_Wrapper.m_UI_Accept;
        public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @Navigation.started += instance.OnNavigation;
            @Navigation.performed += instance.OnNavigation;
            @Navigation.canceled += instance.OnNavigation;
            @Accept.started += instance.OnAccept;
            @Accept.performed += instance.OnAccept;
            @Accept.canceled += instance.OnAccept;
            @Cancel.started += instance.OnCancel;
            @Cancel.performed += instance.OnCancel;
            @Cancel.canceled += instance.OnCancel;
        }

        private void UnregisterCallbacks(IUIActions instance)
        {
            @Navigation.started -= instance.OnNavigation;
            @Navigation.performed -= instance.OnNavigation;
            @Navigation.canceled -= instance.OnNavigation;
            @Accept.started -= instance.OnAccept;
            @Accept.performed -= instance.OnAccept;
            @Accept.canceled -= instance.OnAccept;
            @Cancel.started -= instance.OnCancel;
            @Cancel.performed -= instance.OnCancel;
            @Cancel.canceled -= instance.OnCancel;
        }

        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UIActions @UI => new UIActions(this);

    // Cutscene
    private readonly InputActionMap m_Cutscene;
    private List<ICutsceneActions> m_CutsceneActionsCallbackInterfaces = new List<ICutsceneActions>();
    private readonly InputAction m_Cutscene_Skip;
    public struct CutsceneActions
    {
        private @Player m_Wrapper;
        public CutsceneActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Skip => m_Wrapper.m_Cutscene_Skip;
        public InputActionMap Get() { return m_Wrapper.m_Cutscene; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CutsceneActions set) { return set.Get(); }
        public void AddCallbacks(ICutsceneActions instance)
        {
            if (instance == null || m_Wrapper.m_CutsceneActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CutsceneActionsCallbackInterfaces.Add(instance);
            @Skip.started += instance.OnSkip;
            @Skip.performed += instance.OnSkip;
            @Skip.canceled += instance.OnSkip;
        }

        private void UnregisterCallbacks(ICutsceneActions instance)
        {
            @Skip.started -= instance.OnSkip;
            @Skip.performed -= instance.OnSkip;
            @Skip.canceled -= instance.OnSkip;
        }

        public void RemoveCallbacks(ICutsceneActions instance)
        {
            if (m_Wrapper.m_CutsceneActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICutsceneActions instance)
        {
            foreach (var item in m_Wrapper.m_CutsceneActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CutsceneActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CutsceneActions @Cutscene => new CutsceneActions(this);
    public interface IInGamePlayerActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNavigation(InputAction.CallbackContext context);
        void OnAccept(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
    public interface ICutsceneActions
    {
        void OnSkip(InputAction.CallbackContext context);
    }
}
