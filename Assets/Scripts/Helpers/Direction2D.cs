using System.Collections.Generic;
using UnityEngine;

namespace Helpers
{
    public static class Directions2D
    {
        public static readonly List<Vector2Int> CardinalDirectionsList = new List<Vector2Int>()
        {
            new Vector2Int( 0,  1),
            new Vector2Int( 1,  0),
            new Vector2Int( 0, -1),
            new Vector2Int(-1,  0)
        };

        public static readonly List<Vector2Int> DiagonalDirectionsList = new List<Vector2Int>
        {
            new Vector2Int( 1,  1),
            new Vector2Int(-1,  1),
            new Vector2Int(-1, -1),
            new Vector2Int( 1, -1)
        };

        public static readonly List<Vector2Int> EightDirectionsList = new List<Vector2Int>
        {
            new Vector2Int( 0,  1),
            new Vector2Int( 1,  1),
            new Vector2Int( 1,  0),
            new Vector2Int( 1, -1),
            new Vector2Int( 0, -1),
            new Vector2Int(-1, -1),
            new Vector2Int(-1,  0),
            new Vector2Int(-1,  1)
        };

        public static Vector2Int GetRandomCardinalDirection()
        {
            return CardinalDirectionsList[Random.Range(0, CardinalDirectionsList.Count)];
        }

        public static Vector2Int GetRandomDiagonalDirection()
        {
            return CardinalDirectionsList[Random.Range(0, DiagonalDirectionsList.Count)];
        }

        public static Vector2Int GetRandomEightDirection()
        {
            return CardinalDirectionsList[Random.Range(0, EightDirectionsList.Count)];
        }
    }
}
