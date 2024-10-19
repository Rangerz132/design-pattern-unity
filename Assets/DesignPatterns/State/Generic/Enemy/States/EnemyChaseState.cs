using StateDesignPattern;

public class EnemyChaseState : GenericBaseState<EnemyStateMachine.EnemyStates>
{
    private EnemyStateMachine enemyStateMachine;
    private Enemy enemy;

    public EnemyChaseState(EnemyStateMachine.EnemyStates stateKey, EnemyStateMachine enemyStateMachine, Enemy enemy) : base(stateKey)
    {
        this.enemyStateMachine = enemyStateMachine;
        this.enemy = enemy;
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