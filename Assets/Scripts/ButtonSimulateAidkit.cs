using UnityEngine;

public class ButtonSimulateAidkit : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private float _aidCount;

    public void TakeAidkit()
    {
        _health.Add(_aidCount);
    }
}
