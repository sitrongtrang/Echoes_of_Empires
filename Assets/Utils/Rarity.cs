using System.Collections.Generic;
using UnityEngine;

public enum UnitRarity
{
    Common,
    Uncommon,
    Rare,
    Epic,
    Heroic,
    Mythic,
    Unique,
    Legendary,
    Ultimate
}

public static class RarityMapper
{
    public static readonly Dictionary<UnitRarity, Color> RarityToColor = new Dictionary<UnitRarity, Color> 
    {
        { UnitRarity.Common, Color.white },
        { UnitRarity.Uncommon, Color.green },
        { UnitRarity.Rare, Color.blue },
        { UnitRarity.Epic, new Color(191f / 255f, 64f / 255f, 191f / 255f) },
        { UnitRarity.Heroic, Color.yellow },
        { UnitRarity.Mythic, Color.red },
        { UnitRarity.Unique, Color.magenta },
        { UnitRarity.Legendary, new Color(255f / 255f, 131f / 255f, 83f / 255f) },
        { UnitRarity.Ultimate, new Color(255f / 255f, 94f / 255f, 32f / 255f) },
    };
}