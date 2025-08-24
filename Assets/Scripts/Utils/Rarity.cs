using System;
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

[Serializable]
public class RarityMap
{
    public UnitRarity Rarity;
    public Color Color;
    public Sprite Frame;
    public int FragmentsEquivalent;
}

// public static class Something
// {
//     public static readonly Dictionary<UnitRarity, Color> RarityToColor = new Dictionary<UnitRarity, Color>
//     {
//         { UnitRarity.Common, Color.white },
//         { UnitRarity.Uncommon, Color.green },
//         { UnitRarity.Rare, Color.blue },
//         { UnitRarity.Epic, new Color(191f / 255f, 64f / 255f, 191f / 255f) },
//         { UnitRarity.Heroic, Color.yellow },
//         { UnitRarity.Mythic, Color.red },
//         { UnitRarity.Unique, Color.magenta },
//         { UnitRarity.Legendary, new Color(255f / 255f, 131f / 255f, 83f / 255f) },
//         { UnitRarity.Ultimate, new Color(255f / 255f, 94f / 255f, 32f / 255f) },
//     };
// }

[CreateAssetMenu(fileName = "RarityMapper", menuName = "Mapper/RarityMapper")]
public class RarityMapperSO : ScriptableObject
{
    public RarityMap[] Rarities;

    public Sprite GetFrame(UnitRarity rarity)
    {
        for (int i = 0; i < Rarities.Length; i++)
            if (Rarities[i].Rarity == rarity)
                return Rarities[i].Frame;

        return null;
    }

    public Color GetColor(UnitRarity rarity)
    {
        for (int i = 0; i < Rarities.Length; i++)
            if (Rarities[i].Rarity == rarity)
                return Rarities[i].Color;

        return Color.black;
    }

    public int GetFragmentsEquivalent(UnitRarity rarity)
    {
        for (int i = 0; i < Rarities.Length; i++)
            if (Rarities[i].Rarity == rarity)
                return Rarities[i].FragmentsEquivalent;

        return 0;
    }
}

