using System;
using UnityEngine;

namespace Map
{
    public class MapCreator : MonoBehaviour
    {
        [SerializeField] private Vector2Int size;
        [SerializeField] private MapVisualizer visualizer;
        private Cell[,] _cells;
        private FillType _type;
        private PointsCreator _pointsCreator;
        private Vector2Int _startPoint;
        private Vector2Int _endPoint;

        private void Start()
        {
            _cells = new Cell[size.x, size.y];
            _pointsCreator = new PointsCreator(size,out _startPoint,out _endPoint);
            CreateMap();
        }
        public Cell GetCell(int x, int y)
        {
            return _cells[x, y];
        }
        public Cell GetCell(Vector2Int position)
        {
            GetXY(out int x, out int y, position);
            return GetCell(x, y);
        }
        public Vector3 GetCentralCell()
        {
            int x = size.x / 2;
            int y = size.y / 2;
            return new Vector3(x, y);
        }
        private void CreateMap()
        {
            for (int y = 0; y < size.y; y++)
            {
                for (int x = 0; x < size.x; x++)
                {
                    var position = new Vector3Int(x, y);
                    if (position == (Vector3Int)_startPoint)
                    {
                        CreateCell(x, y, position, FillType.Walkable);
                    }
                    CreateCell(x, y, position, FillType.Unwalkable);
                }
            }
        }
        private void CreateCell(int x, int y, Vector3Int position, FillType type)
        {

            _cells[x, y] = new Cell(position,type);
            visualizer.PaintSingleTile(_cells[x, y]);
        }
        private void GetXY(out int x, out int y, Vector2Int position)
        {
            x = position.x;
            y = position.y;
        }
    }
}
