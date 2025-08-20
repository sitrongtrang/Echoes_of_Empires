public enum UnitClass
{
    None = 0,
    Infantry = 1 << 0,
    Cavalry = 1 << 1,
    Missile = 1 << 2,
    Siege = 1 << 3,
    Support = 1 << 4,
    Chariot = 1 << 5,
    Light = 1 << 6, // true for light units, false for heavy units
    Lord = 1 << 7,
}