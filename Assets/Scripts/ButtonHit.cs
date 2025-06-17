using UnityEngine;

public class ButtonHit : SimulateButton
{
    [SerializeField] private float _damage;

    protected override void SimulateChangeValue()
    {
        MakeHit(_damage);
    }

    private void MakeHit(float damage)
    {
        _health.TakeDamage(_damage);
    }
}