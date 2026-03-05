using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAirState : PlayerState
{
    public PlayAirState(Player _player, PlayerStateMachine _playerStateMachine, string _animBoolName) : base(_player, _playerStateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
        /*player.SetVelocity(0, rb.velocity.y);//×ÔÐÐÐÞ¸´bug*/
    }

    public override void Update()
    {
        base.Update();

        if (player.isWallDetected())
            stateMachine.ChangeState(player.wallSlide);

        if(player.isGroundDetected())
            stateMachine.ChangeState(player.idleState);

        if (xInput != 0)
            player.SetVelocity(player.moveSpeed * .8f * xInput, rb.velocity.y);
    }
}
