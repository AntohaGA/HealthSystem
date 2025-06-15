using System;
using UnityEngine;

public class Health : MonoBehaviour, IDamagable
{
    private const float StartHealth = 100;

    public event Action<float> TakedHit;
    public event Action<float> TakedAidKit;

    public float Max { get; private set; } = StartHealth;
    public float Min { get; private set; } = 0;
    public float Count { get; private set; } = StartHealth;

    private void Awake()
    {
        Count = Max;
    }

    public void TakeDamage(float damage)
    {
        if (Count > Min && damage > 0)
        {
            if (Count - damage >= Min)
                Count -= damage;
            else
                Count = Min;

            TakedHit?.Invoke(Count);
        }
    }

    public void Add(float countHealth)
    {
        if (Count < Max && countHealth > 0)
        {
            if (Count + countHealth <= Max)
                Count += countHealth;
            else
                Count = Max;

            TakedAidKit?.Invoke(Count);
        }
    }
}