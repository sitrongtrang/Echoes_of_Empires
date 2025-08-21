using System;
using UnityEngine;

public class UnitHealth
{
    private UnitController _unit;

    public int MaxHealth { get; private set; }
    public int CurrentHealth { get; private set; }

    public event Action<int> OnHealthChanged;
    public event Action OnDeath;

    public UnitHealth(UnitController unit)
    {
        _unit = unit;
        _unit.OnTurnEnded += OnTurnEnded;

        MaxHealth = _unit.Config.BaseHealth;
        CurrentHealth = MaxHealth;
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        if (CurrentHealth <= 0)
            OnDeath?.Invoke();
    }

    private void OnTurnEnded()
    {
        return;
    }
}