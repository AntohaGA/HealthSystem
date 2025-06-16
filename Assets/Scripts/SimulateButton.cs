using UnityEngine;
using UnityEngine.UI;

public abstract class SimulateButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] protected Health _health;

    protected void OnEnable()
    {
        _button.onClick.AddListener(SimulateSomething);
    }

    protected void OnDisable()
    {
        _button.onClick.RemoveListener(SimulateSomething);
    }

    public abstract void SimulateSomething();
}