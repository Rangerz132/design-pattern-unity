using StrategyDesignPattern;
using UnityEngine;

public class MeleeAttackStrategy : IAttackStrategy
{
    public void Attack()
    {
        // Perform melee attack
        Debug.Log("Melee attack");
    }
}
