using UnityEngine;

public class PlayerStateMachine : StateMachine
{

    public InputReader InputReader { get; private set; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InputReader = GetComponent<InputReader>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
