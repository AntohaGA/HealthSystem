using UnityEngine;

public class ButtonSimulateHit : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private float _damage;

    public void MakeHit()
    {
        _health.TakeDamage(_damage);
    }
}
