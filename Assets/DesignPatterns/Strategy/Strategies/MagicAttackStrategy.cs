using StrategyDesignPattern;
using UnityEngine;

public class MagicAttackStrategy : IAttackStrategy
{
    public void Attack()
    {
        // Perform magic attack
        Debug.Log("Magic attack");
    }
}
