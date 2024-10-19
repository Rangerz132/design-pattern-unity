using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemyStateMachine enemyStateMachine;

    private void Start()
    {
        enemyStateMachine = new EnemyStateMachine(this);
        enemyStateMachine.Initialize(EnemyStateMachine.EnemyStates.Idle);
    }

    private void Update()
    {
        enemyStateMachine.UpdateState();
    }
}