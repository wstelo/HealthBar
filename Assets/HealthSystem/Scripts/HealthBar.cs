using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] protected Health _health;

    private void OnEnable()
    {
        _health.ChangedValue += ChangeValue;
    }

    private void OnDisable()
    {
        _health.ChangedValue -= ChangeValue;
    }

    public virtual void ChangeValue(float value)
    {

    }
}
