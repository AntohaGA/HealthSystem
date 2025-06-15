using TMPro;
using UnityEngine;

public class HealthTextBar : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMeshPro;
    [SerializeField] private Health _health;
    [SerializeField] private string _splitter;

    private float _maxValue;
    private float _value;

    private void Awake()
    {
        _maxValue = _health.MaxHealth;
        _value = _health.Count;

        PrintHealthValues(_maxValue, _value);
    }

    private void OnEnable()
    {
        _health.TakedHit += ChangeValue;
        _health.TakedAidKit += ChangeValue;
    }

    private void OnDisable()
    {
        _health.TakedHit -= ChangeValue;
        _health.TakedAidKit -= ChangeValue;
    }

    public void ChangeValue(float newValue)
    {
        PrintHealthValues(newValue, _maxValue);
    }

    private void PrintHealthValues(float currentHealth, float maxHealth)
    {
        _textMeshPro.text = currentHealth.ToString() + _splitter + maxHealth.ToString();
    }
}