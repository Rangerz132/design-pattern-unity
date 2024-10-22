using UnityEngine;
using FactoryDesignPattern;

public class EntityA : MonoBehaviour, IEntity
{
    public void Attack()
    {
        Debug.Log("EntityA attack");
    }
}
