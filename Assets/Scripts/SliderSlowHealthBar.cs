using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SliderSlowHealthBar : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Slider _slider;
    [SerializeField] private Health _health;

    private IEnumerator _slowChangeCoroutine;

    private void Awake()
    {
        _slider.interactable = false;
        _slider.minValue = _health.Min;
        _slider.maxValue = _health.Max;
        _slider.value = _health.Count;
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
        if(_slowChangeCoroutine != null)
            StopCoroutine(_slowChangeCoroutine);

        _slowChangeCoroutine = ChangeHealthValue(newValue);
        StartCoroutine(_slowChangeCoroutine);
    }

    private IEnumerator ChangeHealthValue(float targetValue)
    {
        while (_slider.value != targetValue)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, targetValue, _speed * Time.deltaTime);

            yield return null;
        }
    }
}