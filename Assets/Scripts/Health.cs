using System;
using UnityEngine;

public class Health : MonoBehaviour, IDamagable
{
    private const float StartHealth = 100;

    private float _min = 0;

    public event Action<float, float> Changed;

    public float Max { get; private set; } = StartHealth;
    public float Count { get; private set; } = StartHealth;

    private void Awake()
    {
        Count = Max;
    }

    public void TakeDamage(float damage)
    {
        if (Count > _min && damage > 0)
        {
            Count = Mathf.Clamp(Count - damage, _min, Max);
            Changed?.Invoke(Count, Max);
        }
    }

    public void Add(float countHealth)
    {
        if (Count < Max && countHealth > 0)
        {
            Count = Mathf.Clamp(Count + countHealth, _min, Max);
            Changed?.Invoke(Count, Max);
        }
    }
}