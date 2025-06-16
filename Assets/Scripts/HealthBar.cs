using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] protected Health _health;

    private void OnEnable()
    {
        _health.Losted += ChangeValue;
        _health.Restored += ChangeValue;
    }

    private void OnDisable()
    {
        _health.Losted -= ChangeValue;
        _health.Restored -= ChangeValue;
    }

    public abstract void ChangeValue(float newValue, float maxValue);
}