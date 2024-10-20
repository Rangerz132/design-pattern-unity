using StrategyDesignPattern;
using UnityEngine;

public class RangeAttackStrategy : IAttackStrategy
{
    public void Attack()
    {
        // Perform range attack
        Debug.Log("Range attack");
    }
}
