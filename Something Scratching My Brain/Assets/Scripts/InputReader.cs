using UnityEngine;
using UnityEngine.InputSystem;
using System;
using System.Threading;

public class InputReader : MonoBehaviour, Controls.IPlayerActions
{
    public event Action JumpEvent;
    public event Action DodgeEvent;

    private Controls controls;

    void Start()
    {
        controls = new Controls();
        controls.Player.SetCallbacks(this);
        controls.Player.Enable();
    }

    private void OnDestroy()
    {
        controls.Player.Disable();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        JumpEvent?.Invoke();
    }

    public void OnDodge(InputAction.CallbackContext context)
    {
        if(!context.performed) return;
        DodgeEvent?.Invoke(); 
    }
}
