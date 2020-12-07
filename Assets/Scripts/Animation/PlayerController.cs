using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float maxSpeed;

    #region Player States
    public readonly IdleState idle = new IdleState();
    public readonly RunState run = new RunState();
    #endregion

    private Rigidbody2D _rBody;
    public Rigidbody2D Rigidbody
    {
        get { return _rBody; }
    }
    public PlayerBaseState CurrentState { get; private set; }

    private void Awake()
    {
        _rBody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        TransitionToState(idle);
        Debug.Log("idle");
    }

    // Update is called once per frame
    void Update()
    {
        CurrentState.Update(this);
        CurrentState.EnterState(this);
    }

    private void FixedUpdate()
    {
       
    }

    public void TransitionToState(PlayerBaseState state)
    {
        CurrentState = state;
        CurrentState.EnterState(this);
        Debug.Log("Current State " + CurrentState.GetType());
    }

    private void OnCollisionEnter(Collision collision)
    {
        CurrentState.OnCollisionEnter(this);
    }
}
