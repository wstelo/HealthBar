using UnityEngine;
using UnityEngine.UI;

public class SimpleHealthBar : HealthBar
{
    [SerializeField] private Slider _slider;

    private void Start()
    {
        _slider.maxValue = _health.MaxValue;
        _slider.value = _health.CurrentValue;
    }

    public override void ChangeValue(float value)
    {
        _slider.value = value;
    }
}
