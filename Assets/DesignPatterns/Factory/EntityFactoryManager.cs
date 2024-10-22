using UnityEngine;

namespace FactoryDesignPattern
{
    public class EntityFactoryManager : MonoBehaviour
    {
        [SerializeField] private EntityFactory entityFactory;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1)) {
                entityFactory.CreateEntity(EntityType.EntityA);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                entityFactory.CreateEntity(EntityType.EntityB);
            }
        }
    }
}
