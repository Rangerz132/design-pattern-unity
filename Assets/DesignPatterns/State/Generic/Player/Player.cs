using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerStateMachine playerStateMachine;

    private void Start()
    {
        playerStateMachine = new PlayerStateMachine(this);
        playerStateMachine.Initialize(PlayerStateMachine.PlayerStates.Idle);
    }

    private void Update()
    {
        playerStateMachine.UpdateState();
    }
}