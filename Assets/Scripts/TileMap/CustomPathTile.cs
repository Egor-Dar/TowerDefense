using UnityEngine;
using UnityEngine.Tilemaps;

namespace TileMap
{
    [CreateAssetMenu(menuName = "2D/Tiles/New Path Tile", fileName = "New Path Tile")]
    public class CustomPathTile : Tile
    {
        [SerializeField] private Sprite[] _sprites;
        
        public void SetSprite()
        {
            sprite = _sprites[0];
        }
    }
}
