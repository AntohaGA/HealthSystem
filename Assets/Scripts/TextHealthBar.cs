using TMPro;
using UnityEngine;

public class TextHealthBar : HealthBar
{
    [SerializeField] private TextMeshProUGUI _textMeshPro;
    [SerializeField] private string _splitter;

    private void Awake()
    {
        PrintHealthValues(_health.Count, _health.Max);
    }

    public override void ChangeValue(float newValue, float maxValue)
    {
        PrintHealthValues(newValue, maxValue);
    }

    private void PrintHealthValues(float currentHealth, float maxHealth)
    {
        _textMeshPro.text = currentHealth.ToString() + _splitter + maxHealth.ToString();
    }
}