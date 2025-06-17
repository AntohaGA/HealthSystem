using UnityEngine;
using UnityEngine.UI;

public class SliderHealthBar : HealthBar
{
    [SerializeField] protected Slider Slider;

    private void Awake()
    {
        Slider.interactable = false;
        Slider.minValue = 0;
        Slider.maxValue = 1;
        OnChanged(Health.Count, 1);
    }

    public override void OnChanged(float value, float maxValue)
    {
        Slider.value = value / maxValue;
    }
}