using UnityEngine;
using StrategyDesignPattern;

public class Character : MonoBehaviour
{
    private IAttackStrategy attackStrategy;

    private void Start()
    {
        // Default attack strategy
        attackStrategy = new MeleeAttackStrategy();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            attackStrategy.Attack();
        }
    }

    public void SetAttackStrategy(IAttackStrategy attackStrategy)
    {
        this.attackStrategy = attackStrategy;
    }
}
