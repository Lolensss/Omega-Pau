using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float normalSpeed = 12f;
    float currentSpeed;

    void Start()
    {
        currentSpeed = normalSpeed;
    }

    public float GetSpeed()
    {
        return currentSpeed;
    }

    public void BoostSpeed(float amount, float duration)
    {
        StartCoroutine(SpeedBoost(amount, duration));
    }

    IEnumerator SpeedBoost(float amount, float duration)
    {
        currentSpeed += amount;

        Debug.Log("Speed Boost Activated");

        yield return new WaitForSeconds(duration);

        currentSpeed = normalSpeed;

        Debug.Log("Speed Boost Ended");
    }
}