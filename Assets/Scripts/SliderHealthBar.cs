using UnityEngine;
using UnityEngine.UI;

public class SliderHealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Health _health;

    private float _value;

    private void Awake()
    {
        _slider.interactable = false;
        _value = _health.Count;
        _slider.minValue = _health.Min;
        _slider.maxValue = _health.Max;
        ApplyNewHealth(_value);
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

    public void ChangeValue(float value)
    {
        ApplyNewHealth(value);
    }

    private void ApplyNewHealth(float value)
    {
        _slider.value = value;
    }
}