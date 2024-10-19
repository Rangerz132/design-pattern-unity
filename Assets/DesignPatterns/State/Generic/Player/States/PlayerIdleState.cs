using StateDesignPattern;

public class PlayerIdleState : GenericBaseState<PlayerStateMachine.PlayerStates>
{
    private PlayerStateMachine playerStateMachine;
    private Player player;

    public PlayerIdleState(PlayerStateMachine.PlayerStates stateKey, PlayerStateMachine playerStateMachine, Player player) : base(stateKey)
    {
        this.playerStateMachine = playerStateMachine;
        this.player = player;
    }

    public override void EnterState()
    {

    }

    public override void ExitState()
    {

    }

    public override void UpdateState()
    {

    }

    public override void FixedUpdateState()
    {

    }
}