using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunState : PlayerBaseState
{
    public override void EnterState(PlayerController player)
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        player.Rigidbody.velocity = new Vector2(horizontalInput * player.maxSpeed, player.Rigidbody.velocity.y);
    }

    public override void OnCollisionEnter(PlayerController player)
    {
        throw new System.NotImplementedException();
    }

    public override void Update(PlayerController player)
    {      
       
    }
}
