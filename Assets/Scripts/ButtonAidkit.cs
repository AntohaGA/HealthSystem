using UnityEngine;

public class ButtonAidkit : SimulateButton
{
    [SerializeField] private float _aidCount;

    public override void SimulateSomething()
    {
        TakeAidkit(_aidCount);
    }

    public void TakeAidkit(float aidCount)
    {
        _health.Add(aidCount);
    }
}
