using UnityEngine;
using UnityEngine.UI;

public class SmoothHealthBar : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Slider _slider;
    [SerializeField] private float _delay = 1f;

    private float _value = 0;

    private void Start()
    {
        _slider.maxValue = _health.MaxValue;
        _slider.value = _health.CurrentValue;
        _value = _health.CurrentValue;
    }

    private void Update()
    {
        if(_value != _slider.value)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _value, _delay * Time.deltaTime);
        }
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
        _value = value;
    }
}
