using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] protected Health _health;

    private void OnEnable()
    {
        _health.Changed += ChangeValue;
    }

    private void OnDisable()
    {
        _health.Changed -= ChangeValue;
    }

    public abstract void ChangeValue(float newValue, float maxValue);
}