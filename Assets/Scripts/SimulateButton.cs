using UnityEngine;
using UnityEngine.UI;

public abstract class SimulateButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] protected Health _health;

    protected void OnEnable()
    {
        _button.onClick.AddListener(SimulateChangeValue);
    }

    protected void OnDisable()
    {
        _button.onClick.RemoveListener(SimulateChangeValue);
    }

    protected abstract void SimulateChangeValue();
}