using UnityEngine;
using UnityEngine.Tilemaps;

namespace Map
{
    public class MapVisualizer : MonoBehaviour
    {
        [SerializeField] private Tilemap[] tilemaps;
        [SerializeField] private Tile[] walkableTiles;
        [SerializeField] private Tile[] unWalkableTiles;
        [SerializeField] private Tile startTile;
        [SerializeField] private Tile endTile;
        
        public void PaintSingleTile(Cell cell)
        {
            var position = cell.Position;
            var type = cell.Type;
            var index = cell.Index;
            switch (type)
            {
                case FillType.Walkable:
                    tilemaps[0].SetTile(position,walkableTiles[index]);
                    break;                
                case FillType.Unwalkable:
                    tilemaps[0].SetTile(position,unWalkableTiles[index]);
                    break;
            }
            
        }
    }
}
