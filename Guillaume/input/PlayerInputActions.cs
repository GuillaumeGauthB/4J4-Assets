//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Guillaume/input/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Mouvements-tests"",
            ""id"": ""85060870-9f1c-4154-850c-b54bf4be0c9d"",
            ""actions"": [
                {
                    ""name"": ""Attaque Physique"",
                    ""type"": ""Button"",
                    ""id"": ""3a33357f-2586-42be-bc5f-01aaa5e570f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attaque Tir"",
                    ""type"": ""Button"",
                    ""id"": ""4a0034db-aac5-4760-866e-c9dec9e2c65d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AnnulerTir"",
                    ""type"": ""Button"",
                    ""id"": ""e70c25f0-4842-4d72-9e79-2f35202e6224"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Viser"",
                    ""type"": ""Value"",
                    ""id"": ""2b74c334-bf86-4f2e-b78b-2f60618e4fa3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c3d805be-becc-486c-a166-b8036c26114f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attaque Physique"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be2013c8-44dd-4532-b0a3-44baae206efd"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attaque Tir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""820970a0-c878-4480-ba23-fdf180ed2850"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnnulerTir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aea551d9-d9a3-41c8-a1b9-3a0e3e2c96d9"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Viser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Viser"",
            ""id"": ""22496555-e8b0-4a46-b9c6-482ec97f75e6"",
            ""actions"": [
                {
                    ""name"": ""Direction balle"",
                    ""type"": ""Value"",
                    ""id"": ""e2330869-4afd-4d3c-b5bd-718bbd63be2a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b5ecda09-e05f-4c72-8373-7515b78a10d9"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction balle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Mouvements-tests
        m_Mouvementstests = asset.FindActionMap("Mouvements-tests", throwIfNotFound: true);
        m_Mouvementstests_AttaquePhysique = m_Mouvementstests.FindAction("Attaque Physique", throwIfNotFound: true);
        m_Mouvementstests_AttaqueTir = m_Mouvementstests.FindAction("Attaque Tir", throwIfNotFound: true);
        m_Mouvementstests_AnnulerTir = m_Mouvementstests.FindAction("AnnulerTir", throwIfNotFound: true);
        m_Mouvementstests_Viser = m_Mouvementstests.FindAction("Viser", throwIfNotFound: true);
        // Viser
        m_Viser = asset.FindActionMap("Viser", throwIfNotFound: true);
        m_Viser_Directionballe = m_Viser.FindAction("Direction balle", throwIfNotFound: true);
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

    // Mouvements-tests
    private readonly InputActionMap m_Mouvementstests;
    private IMouvementstestsActions m_MouvementstestsActionsCallbackInterface;
    private readonly InputAction m_Mouvementstests_AttaquePhysique;
    private readonly InputAction m_Mouvementstests_AttaqueTir;
    private readonly InputAction m_Mouvementstests_AnnulerTir;
    private readonly InputAction m_Mouvementstests_Viser;
    public struct MouvementstestsActions
    {
        private @PlayerInputActions m_Wrapper;
        public MouvementstestsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @AttaquePhysique => m_Wrapper.m_Mouvementstests_AttaquePhysique;
        public InputAction @AttaqueTir => m_Wrapper.m_Mouvementstests_AttaqueTir;
        public InputAction @AnnulerTir => m_Wrapper.m_Mouvementstests_AnnulerTir;
        public InputAction @Viser => m_Wrapper.m_Mouvementstests_Viser;
        public InputActionMap Get() { return m_Wrapper.m_Mouvementstests; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouvementstestsActions set) { return set.Get(); }
        public void SetCallbacks(IMouvementstestsActions instance)
        {
            if (m_Wrapper.m_MouvementstestsActionsCallbackInterface != null)
            {
                @AttaquePhysique.started -= m_Wrapper.m_MouvementstestsActionsCallbackInterface.OnAttaquePhysique;
                @AttaquePhysique.performed -= m_Wrapper.m_MouvementstestsActionsCallbackInterface.OnAttaquePhysique;
                @AttaquePhysique.canceled -= m_Wrapper.m_MouvementstestsActionsCallbackInterface.OnAttaquePhysique;
                @AttaqueTir.started -= m_Wrapper.m_MouvementstestsActionsCallbackInterface.OnAttaqueTir;
                @AttaqueTir.performed -= m_Wrapper.m_MouvementstestsActionsCallbackInterface.OnAttaqueTir;
                @AttaqueTir.canceled -= m_Wrapper.m_MouvementstestsActionsCallbackInterface.OnAttaqueTir;
                @AnnulerTir.started -= m_Wrapper.m_MouvementstestsActionsCallbackInterface.OnAnnulerTir;
                @AnnulerTir.performed -= m_Wrapper.m_MouvementstestsActionsCallbackInterface.OnAnnulerTir;
                @AnnulerTir.canceled -= m_Wrapper.m_MouvementstestsActionsCallbackInterface.OnAnnulerTir;
                @Viser.started -= m_Wrapper.m_MouvementstestsActionsCallbackInterface.OnViser;
                @Viser.performed -= m_Wrapper.m_MouvementstestsActionsCallbackInterface.OnViser;
                @Viser.canceled -= m_Wrapper.m_MouvementstestsActionsCallbackInterface.OnViser;
            }
            m_Wrapper.m_MouvementstestsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @AttaquePhysique.started += instance.OnAttaquePhysique;
                @AttaquePhysique.performed += instance.OnAttaquePhysique;
                @AttaquePhysique.canceled += instance.OnAttaquePhysique;
                @AttaqueTir.started += instance.OnAttaqueTir;
                @AttaqueTir.performed += instance.OnAttaqueTir;
                @AttaqueTir.canceled += instance.OnAttaqueTir;
                @AnnulerTir.started += instance.OnAnnulerTir;
                @AnnulerTir.performed += instance.OnAnnulerTir;
                @AnnulerTir.canceled += instance.OnAnnulerTir;
                @Viser.started += instance.OnViser;
                @Viser.performed += instance.OnViser;
                @Viser.canceled += instance.OnViser;
            }
        }
    }
    public MouvementstestsActions @Mouvementstests => new MouvementstestsActions(this);

    // Viser
    private readonly InputActionMap m_Viser;
    private IViserActions m_ViserActionsCallbackInterface;
    private readonly InputAction m_Viser_Directionballe;
    public struct ViserActions
    {
        private @PlayerInputActions m_Wrapper;
        public ViserActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Directionballe => m_Wrapper.m_Viser_Directionballe;
        public InputActionMap Get() { return m_Wrapper.m_Viser; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ViserActions set) { return set.Get(); }
        public void SetCallbacks(IViserActions instance)
        {
            if (m_Wrapper.m_ViserActionsCallbackInterface != null)
            {
                @Directionballe.started -= m_Wrapper.m_ViserActionsCallbackInterface.OnDirectionballe;
                @Directionballe.performed -= m_Wrapper.m_ViserActionsCallbackInterface.OnDirectionballe;
                @Directionballe.canceled -= m_Wrapper.m_ViserActionsCallbackInterface.OnDirectionballe;
            }
            m_Wrapper.m_ViserActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Directionballe.started += instance.OnDirectionballe;
                @Directionballe.performed += instance.OnDirectionballe;
                @Directionballe.canceled += instance.OnDirectionballe;
            }
        }
    }
    public ViserActions @Viser => new ViserActions(this);
    public interface IMouvementstestsActions
    {
        void OnAttaquePhysique(InputAction.CallbackContext context);
        void OnAttaqueTir(InputAction.CallbackContext context);
        void OnAnnulerTir(InputAction.CallbackContext context);
        void OnViser(InputAction.CallbackContext context);
    }
    public interface IViserActions
    {
        void OnDirectionballe(InputAction.CallbackContext context);
    }
}
