using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private PlayerCamera playerCamera;

    PlayerInput palyerInput;
    PlayerInput.MovementActions movementActions;

    Vector2 horizontalInput;
    Vector2 mouseInput;

    private void Awake() {
        palyerInput = new PlayerInput();
        movementActions = palyerInput.Movement;

        movementActions.HorizontalMov.performed += ctx => horizontalInput = ctx.ReadValue<Vector2>();
        movementActions.MouseX.performed += ctx => mouseInput.x = ctx.ReadValue<float>();
        movementActions.MouseY.performed += ctx => mouseInput.y = ctx.ReadValue<float>();
    }
    private void Update() {
        playerMovement.ReceiveInput(horizontalInput);
        playerCamera.ReceiveInput(mouseInput);
    }

    private void OnEnable() {
        palyerInput.Enable();
    }
    private void OnDestroy() {
        palyerInput.Disable();
    }
}
