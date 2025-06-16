using System.Collections;
using UnityEngine;

public class SliderSlowHealthBar : SliderHealthBar
{
    [SerializeField] private float _speed;

    private Coroutine _slowChangeCoroutine;

    public override void ChangeValue(float newValue, float maxValue)
    {
        if (_slowChangeCoroutine != null)
            StopCoroutine(_slowChangeCoroutine);

        _slowChangeCoroutine = StartCoroutine(ChangeHealthValue(newValue, maxValue));
    }

    private IEnumerator ChangeHealthValue(float targetValue, float maxValue)
    {
        float startValue = _slider.value;
        float time = 0;

        while (time < 1)
        {
            time += _speed * Time.deltaTime;
            _slider.value = Mathf.Lerp(startValue, targetValue/maxValue, time);

            yield return null;
        }
    }
}