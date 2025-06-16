using UnityEngine;
using UnityEngine.UI;

public class SliderHealthBar : HealthBar
{
    [SerializeField] protected Slider _slider;

    private void Awake()
    {
        _slider.interactable = false;
        _slider.minValue = 0;
        _slider.maxValue = 1;
        ChangeValue(_health.Count, 1);
    }

    public override void ChangeValue(float value, float maxValue)
    {
        ApplyNewHealth(value, maxValue);
    }

    private void ApplyNewHealth(float value, float maxValue)
    {
        _slider.value = value / maxValue;
    }
}