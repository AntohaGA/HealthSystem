using UnityEngine;

public class ButtonAidkit : SimulateButton
{
    [SerializeField] private float _aidCount;

    protected override void SimulateChangeValue()
    {
        TakeAidkit(_aidCount);
    }

    private void TakeAidkit(float aidCount)
    {
        _health.Add(aidCount);
    }
}