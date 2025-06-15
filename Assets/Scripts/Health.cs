using System;
using UnityEngine;

public class Health : MonoBehaviour, IDamagable
{
    public event Action<float> TakedHit;
    public event Action<float> TakedAidKit;

    public float MaxHealth { get; private set; } = 100;
    public float MinHealth { get; private set; } = 0;
    public float Count { get; private set; }

    private void Awake()
    {
        Count = MaxHealth;
    }

    public void TakeDamage(float damage)
    {
        if (Count > 0 && damage > 0)
        {
            if(Count - damage >= MinHealth)
            {
                Count -= damage;
                TakedHit?.Invoke(Count);
            }
            else
            {
                Count = MinHealth;
                TakedHit?.Invoke(Count);
            }
        }
    }

    public void Add(float countHealth)
    {
        if (countHealth > 0)
        {
            Count += countHealth;

            if (Count > MaxHealth )
            {
                Count = MaxHealth;
            }

            TakedAidKit?.Invoke(Count);
        }
    }
}