using UnityEngine;
using FactoryDesignPattern;

public class EntityB : MonoBehaviour, IEntity
{
    public void Attack()
    {
        Debug.Log("EntityB attack");
    }
}
