using StateDesignPattern;

public class EnemyStateMachine : GenericStateMachineManager<EnemyStateMachine.EnemyStates, Enemy>
{
    public enum EnemyStates
    {
        Idle,
        Patrol,
        Chase
    }

    public EnemyStateMachine(Enemy enemy) : base(enemy)
    {
        states.Add(EnemyStates.Idle, new EnemyIdleState(EnemyStates.Idle, this, enemy));
        states.Add(EnemyStates.Patrol, new EnemyPatrolState(EnemyStates.Patrol, this, enemy));
        states.Add(EnemyStates.Chase, new EnemyChaseState(EnemyStates.Chase, this, enemy));
    }
}