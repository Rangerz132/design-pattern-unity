using UnityEngine;

namespace FactoryDesignPattern
{
    public enum EntityType
    {
        EntityA,
        EntityB
    }

    public class EntityFactory : MonoBehaviour
    {
        public IEntity CreateEntity(EntityType entityType)
        {
            switch (entityType)
            {
                case EntityType.EntityA:
                    return new EntityA();
                    break;
                case EntityType.EntityB:
                    return new EntityB();
                    break;
            }

            return null;
        }
    }
}
