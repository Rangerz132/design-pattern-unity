using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateDesignPattern;

public class PlayerStateMachine : GenericStateMachineManager<PlayerStateMachine.PlayerStates, Player>
{
    public enum PlayerStates
    {
        Idle,
        Walk,
    }

    public PlayerStateMachine(Player player) : base(player)
    {
        states.Add(PlayerStates.Idle, new PlayerIdleState(PlayerStates.Idle, this, player));
        states.Add(PlayerStates.Walk, new PlayerWalkState(PlayerStates.Walk, this, player));
    }
}