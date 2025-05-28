using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Slider _slider;

    private void Start()
    {
        _slider.maxValue = _health.MaxValue;
        _slider.value = _health.CurrentValue;
    }

    private void OnEnable()
    {
        _health.ChangedValue += ChangeValue;
    }

    private void OnDisable()
    {
        _health.ChangedValue -= ChangeValue;
    }

    private void ChangeValue(float value)
    {
        _slider.value = value;
    }
}
