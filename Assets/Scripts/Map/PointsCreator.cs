using System.Collections.Generic;
using Helpers;
using Unity.VisualScripting;
using UnityEngine;

namespace Map
{
    public class PointsCreator
    {
        private Vector2Int _size;
        public PointsCreator(Vector2Int size, out Vector2Int endPoint, out Vector2Int startPoint)
        {
            _size = size;
            startPoint = default;
            startPoint = CalculatePoint(startPoint);
            endPoint = CalculatePoint(startPoint);
        }

        private Vector2Int CalculatePoint(Vector2Int startPoint)
        {
            var position = Vector2Int.zero;
            var directions = Directions2D.CardinalDirectionsList;
            var randomDirection = Random.Range(0, directions.Count);
            switch (randomDirection)
            {
                case 0:
                    do
                    {
                        position = new Vector2Int( Random.Range(1, _size.x),_size.y - 1);
                    } while (Vector2Int.Distance(startPoint, position) <= 1);
                    break;

                case 1:
                    do
                    {
                        position = new Vector2Int(_size.x,Random.Range(1, _size.y));
                    } while (Vector2Int.Distance(startPoint, position) <= 1);
                    break;

                case 2:
                    do
                    {
                        position = new Vector2Int(Random.Range(1, _size.x),1);
                    } while (Vector2Int.Distance(startPoint, position) <= 1);
                    break;

                case 3:
                    do
                    {
                        position = new Vector2Int(1, Random.Range(1, _size.y));
                    } while (Vector2Int.Distance(startPoint, position) <= 1);
                    break;
            }
            return position;
        }
    }
}
