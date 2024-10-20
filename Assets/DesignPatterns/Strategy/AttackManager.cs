using UnityEngine;

public class CharacterAttackManager : MonoBehaviour
{
    [SerializeField] private Character character;

    private MeleeAttackStrategy meleeAttackStrategy;
    private RangeAttackStrategy rangeAttackStrategy;
    private MagicAttackStrategy magicAttackStrategy;

    private void Start()
    {
        meleeAttackStrategy = new MeleeAttackStrategy();
        rangeAttackStrategy = new RangeAttackStrategy();
        magicAttackStrategy = new MagicAttackStrategy();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            character.SetAttackStrategy(meleeAttackStrategy);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            character.SetAttackStrategy(rangeAttackStrategy);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            character.SetAttackStrategy(magicAttackStrategy);
        }
    }
}
