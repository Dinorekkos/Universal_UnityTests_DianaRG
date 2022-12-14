//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.1
//     from Assets/_Dino/Scripts/Player/Input/PlayerInput.inputactions
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

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""7fd465e3-23e2-42e4-a8d4-f34863b03d5d"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMov"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a3461069-5eac-41c7-968f-9936f7e75341"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""34ad83f6-3be5-408a-abf0-6bfc0084d7fe"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""69746bdd-1440-418e-a85c-7c91d0d2a2fd"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseVector"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ba855c6d-713f-4b35-b810-fa7e1006406e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""0faf1fc2-7594-42c9-a3f5-1bb0749fa8a5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMov"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1da5690b-45e2-4bac-9e8e-be7581c374e8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMov"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4dd4b0c2-4224-42dc-9004-f975645b2642"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMov"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b248ef17-4a5e-42ad-83ee-9a5b01b01466"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMov"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9e5fd3c0-149e-429b-8f93-7d46846a491f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMov"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9a7e819b-b3b0-4363-bef3-4e95c670425f"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0fb17abc-c10b-45c9-a614-f54b892e6d0a"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c730d259-feef-4f0e-86f2-4ac1e3cbf2c0"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_HorizontalMov = m_Movement.FindAction("HorizontalMov", throwIfNotFound: true);
        m_Movement_MouseX = m_Movement.FindAction("MouseX", throwIfNotFound: true);
        m_Movement_MouseY = m_Movement.FindAction("MouseY", throwIfNotFound: true);
        m_Movement_MouseVector = m_Movement.FindAction("MouseVector", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_HorizontalMov;
    private readonly InputAction m_Movement_MouseX;
    private readonly InputAction m_Movement_MouseY;
    private readonly InputAction m_Movement_MouseVector;
    public struct MovementActions
    {
        private @PlayerInput m_Wrapper;
        public MovementActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMov => m_Wrapper.m_Movement_HorizontalMov;
        public InputAction @MouseX => m_Wrapper.m_Movement_MouseX;
        public InputAction @MouseY => m_Wrapper.m_Movement_MouseY;
        public InputAction @MouseVector => m_Wrapper.m_Movement_MouseVector;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @HorizontalMov.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontalMov;
                @HorizontalMov.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontalMov;
                @HorizontalMov.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontalMov;
                @MouseX.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseY;
                @MouseVector.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseVector;
                @MouseVector.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseVector;
                @MouseVector.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseVector;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMov.started += instance.OnHorizontalMov;
                @HorizontalMov.performed += instance.OnHorizontalMov;
                @HorizontalMov.canceled += instance.OnHorizontalMov;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
                @MouseVector.started += instance.OnMouseVector;
                @MouseVector.performed += instance.OnMouseVector;
                @MouseVector.canceled += instance.OnMouseVector;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    public interface IMovementActions
    {
        void OnHorizontalMov(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
        void OnMouseVector(InputAction.CallbackContext context);
    }
}
