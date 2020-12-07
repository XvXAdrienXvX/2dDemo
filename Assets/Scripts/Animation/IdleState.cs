using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : PlayerBaseState
{
    public override void EnterState(PlayerController player)
    {
        Debug.Log("idle State");
    }

    public override void OnCollisionEnter(PlayerController player)
    {
        player.TransitionToState(player.idle);
    }

    public override void Update(PlayerController player)
    {        
        player.TransitionToState(player.run);
    }
}
