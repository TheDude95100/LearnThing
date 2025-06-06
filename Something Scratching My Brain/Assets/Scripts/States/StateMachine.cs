using System.Runtime.InteropServices.WindowsRuntime;
using System.Transactions;
using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{
    private State currentState;

    private void Update()
    {
        currentState?.Tick(Time.deltaTime);
    }

    void SwitchState(State newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentState?.Enter();
    }
}
