using System;
using UnityEngine;

public class UnitAttack
{
    private UnitController _unit;

    public int BaseDamage { get; private set; }
    public int BaseRange { get; private set; }
    public int CurrentDamage { get; private set; }
    public int CurrentRange { get; private set; }
    public Vector2Int CurrentLocation { get; private set; }

    public UnitAttack(UnitController unit)
    {
        _unit = unit;
        _unit.OnTurnEnded += OnTurnEnded;

        BaseDamage = _unit.Config.BaseDamage;
        BaseRange = _unit.Config.BaseAttackRange;
        CurrentDamage = BaseDamage;
        CurrentRange = BaseRange;
    }

    public void Attack(UnitController targetUnit)
    {
        if (Utilities.ManhattanDistance(_unit.Movement.CurrentLocation, targetUnit.Movement.CurrentLocation) <= CurrentRange)
        {
            targetUnit.Health.TakeDamage(CurrentDamage);
        }
    }

    private void OnTurnEnded()
    {
        return;
    }
}