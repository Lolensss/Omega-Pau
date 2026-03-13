using UnityEngine;

public class Armor : MonoBehaviour
{
    public float armorValue = 0f;

    public void AddArmor(float amount)
    {
        armorValue += amount;
        Debug.Log("Armor: " + armorValue);
    }

    public float ReduceDamage(float damage)
    {
        if (armorValue > 0)
        {
            float absorbed = damage * 0.5f;

            armorValue -= absorbed;

            if (armorValue < 0)
                armorValue = 0;

            return damage - absorbed;
        }

        return damage;
    }
}