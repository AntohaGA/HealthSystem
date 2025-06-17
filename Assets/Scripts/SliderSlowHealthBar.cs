using System.Collections;
using UnityEngine;

public class SliderSlowHealthBar : SliderHealthBar
{
    [SerializeField] private float _speed;

    private Coroutine _slowChangeCoroutine;

    public override void OnChanged(float newValue, float maxValue)
    {
        if (_slowChangeCoroutine != null)
            StopCoroutine(_slowChangeCoroutine);

        _slowChangeCoroutine = StartCoroutine(SlowChangeValue(newValue, maxValue));
    }

    private IEnumerator SlowChangeValue(float targetValue, float maxValue)
    {
        const float TargetTime = 1;

        float startValue = Slider.value;
        float time = 0;

        while (time < TargetTime)
        {
            time += _speed * Time.deltaTime;
            Slider.value = Mathf.Lerp(startValue, targetValue/maxValue, time);

            yield return null;
        }
    }
}