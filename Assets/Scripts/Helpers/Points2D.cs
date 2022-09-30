using UnityEngine;

namespace Helpers
{
    public static class Points2D
    {
        public static Vector2Int GetRandomPoints(Vector2Int min,Vector2Int max)
        {
            int x = Random.Range(min.x, max.x);
            int y = Random.Range(min.y, max.y);
            return new Vector2Int(x, y);
        }
    }
}
