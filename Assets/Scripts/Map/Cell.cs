using UnityEngine;

namespace Map
{
    public struct Cell
    {
        public Vector3Int Position;
        public FillType Type;
        public int Index;

        public Cell(Vector3Int position, FillType type = FillType.Walkable, int index = 0)
        {
            Position = position;
            Type = type;
            Index = index;
        }
    }
}
