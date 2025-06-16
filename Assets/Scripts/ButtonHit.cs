using UnityEngine;

public class ButtonHit : SimulateButton
{
    [SerializeField] private float _damage;

    public override void SimulateSomething()
    {
        MakeHit(_damage);
    }

    public void MakeHit(float damage)
    {
        _health.TakeDamage(_damage);
    }
}