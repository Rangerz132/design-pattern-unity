using StateDesignPattern;

public class PlayerWalkState : GenericBaseState<PlayerStateMachine.PlayerStates>
{
    private PlayerStateMachine playerStateMachine;
    private Player player;

    public PlayerWalkState(PlayerStateMachine.PlayerStates stateKey, PlayerStateMachine playerStateMachine, Player player) : base(stateKey)
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