using System;
using Map;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private MapCreator map;
    private void Start()
    {
        var position = map.GetCentralCell();
        position.z = -1;
        mainCamera.transform.position = position;
    }
}
