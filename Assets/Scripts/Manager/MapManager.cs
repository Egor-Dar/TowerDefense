using System;
using TileMap;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Manager
{
    public class MapManager : MonoBehaviour
    {
        [SerializeField] private Tilemap ground;
        [SerializeField] private CustomPathTile pathTile;
        private void Start()
        {
            ground.SetTile(new Vector3Int(0,0),pathTile);
            pathTile.SetSprite();

        }
    }
}
