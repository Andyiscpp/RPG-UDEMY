using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMoveState : PlayerGroundedState
{
    public PlayMoveState(Player _player, PlayerStateMachine _playerStateMachine, string _animBoolName) : base(_player, _playerStateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();

        player.SetVelocity(xInput * player.moveSpeed, rb.velocity.y);

       if(xInput == 0 || player.isWallDetected())
            stateMachine.ChangeState(player.idleState);
    }
}
