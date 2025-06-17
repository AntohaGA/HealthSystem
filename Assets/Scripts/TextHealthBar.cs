using TMPro;
using UnityEngine;

public class TextHealthBar : HealthBar
{
    [SerializeField] private TextMeshProUGUI _textMeshPro;
    [SerializeField] private string _splitter;

    private void Awake()
    {
        PrintHealthValues(Health.Count, Health.Max);
    }

    public override void OnChanged(float newValue, float maxValue)
    {
        PrintHealthValues(newValue, maxValue);
    }

    private void PrintHealthValues(float currentHealth, float maxHealth)
    {
        _textMeshPro.text = currentHealth.ToString() + _splitter + maxHealth.ToString();
    }
}