using System;
using UnityEngine;

public class UnitMovement
{
    private UnitController _unit;

    public int BaseRange { get; private set; }
    public int CurrentRange { get; private set; }
    public Vector2Int CurrentLocation { get; private set; }

    public UnitMovement(UnitController unit)
    {
        _unit = unit;
        _unit.OnTurnEnded += OnTurnEnded;

        BaseRange = _unit.Config.BaseMovementRange;
        CurrentRange = BaseRange;
    }

    public void Move(Vector2Int newLocation)
    {
        if (Utilities.ManhattanDistance(CurrentLocation, newLocation) <= CurrentRange)
        {
            CurrentLocation = newLocation;
        }
    }

    private void OnTurnEnded()
    {
        return;
    }
}