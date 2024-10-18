using System;
using UnityEngine;
using PoolDesignPattern;

public class ProjectilePoolManager : PoolManager<ProjectileType>
{
    public static Func<ProjectileType, GameObject> OnGetProjectile { get; private set; }

    private void OnEnable()
    {
        OnGetProjectile += GetPooledObject;
    }

    private void OnDisable()
    {
        OnGetProjectile -= GetPooledObject;
    }
}
