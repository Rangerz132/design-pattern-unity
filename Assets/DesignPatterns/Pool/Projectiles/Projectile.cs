using UnityEngine;
using PoolDesignPattern;

public enum ProjectileType
{
    Standard,
    Explosive,
    Piercing
}

public class Projectile : MonoBehaviour
{
    [field: SerializeField] public ProjectileType ProjectileType { get; private set; }
    [field: SerializeField] public float LifeTime { get; private set; }
    private float currentLifeTime;

    private void OnEnable()
    {
        ResetLifeTime();
    }

    protected virtual void Update()
    {
        DestroyProjectile();
    }

    public void ResetLifeTime()
    {
        currentLifeTime = LifeTime;
    }

    public void DestroyProjectile()
    {
        currentLifeTime -= Time.deltaTime;

        if (currentLifeTime <= 0)
        {
            if (TryGetComponent(out PooledObject pooledObject))
            {
                pooledObject.ReturnToPool();
            }
        }
    }
}
