using System.Collections.Generic;

public enum UnitCultureGroup
{
    None,
    Germanic,
    Latin,
    Iberian,
    Byzantine
}

public enum UnitCulture
{
    None,

    // Germanic
    English,

    // Latin
    Roman,

    // Iberian
    Castilian

    // Byzantine
}

public static class CultureData
{
    private static readonly Dictionary<UnitCulture, UnitCultureGroup> cultureToGroup =
        new Dictionary<UnitCulture, UnitCultureGroup>
        {
            { UnitCulture.Roman,       UnitCultureGroup.Latin },

            { UnitCulture.English,     UnitCultureGroup.Germanic },

            { UnitCulture.Castilian,   UnitCultureGroup.Iberian },

            { UnitCulture.None,        UnitCultureGroup.None }
        };

    public static UnitCultureGroup GetGroup(UnitCulture culture)
    {
        return cultureToGroup[culture];
    }
}
