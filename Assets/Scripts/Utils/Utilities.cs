using UnityEngine;

public static class Utilities
{
    public static int ManhattanDistance(Vector3Int a, Vector3 b)
    {
        return Mathf.Abs((int)(a.x - b.x)) + Mathf.Abs((int)(a.y - b.y)) + Mathf.Abs((int)(a.z - b.z));
    }

    public static int ManhattanDistance(Vector2Int a, Vector2Int b)
    {
        return Mathf.Abs(a.x - b.x) + Mathf.Abs(a.y - b.y);
    }
}