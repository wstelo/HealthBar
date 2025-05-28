using UnityEngine;
using TMPro;

public class TextHealthBar : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private TMP_Text _text;

    private void Start()
    {
        _text.text = $"{_health.CurrentValue} / {_health.MaxValue} ";
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
        _text.text = $"{value} / {_health.MaxValue} ";
    }
}
