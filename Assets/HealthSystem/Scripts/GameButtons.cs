using UnityEngine;
using UnityEngine.UI;

public class GameButtons : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Button _damageButton;
    [SerializeField] private Button _healButton;

    private float _value = 20;

    private void OnEnable()
    {
        _damageButton.onClick.AddListener(DecreaseValue);
        _healButton.onClick.AddListener(IncreaseValue);
    }

    private void OnDisable()
    {
        _damageButton.onClick.RemoveListener(DecreaseValue);
        _healButton.onClick.RemoveListener(IncreaseValue);
    }

    private void IncreaseValue()
    {
        _health.IncreaseHealth(_value);
    }

    private void DecreaseValue()
    {
        _health.TakeDamage(_value);
    }
}
