using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public enum PowerType
    {
        Speed,
        Health,
        Armor
    }

    public PowerType type;

    public float value = 20f;
    public float duration = 5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (type == PowerType.Health)
            {
                other.GetComponent<Health>()?.AddHealth(value);
            }

            if (type == PowerType.Armor)
            {
                other.GetComponent<Armor>()?.AddArmor(value);
            }

            if (type == PowerType.Speed)
            {
                other.GetComponent<PlayerMovement>()?.BoostSpeed(value, duration);
            }

            Destroy(gameObject);
        }
    }
}