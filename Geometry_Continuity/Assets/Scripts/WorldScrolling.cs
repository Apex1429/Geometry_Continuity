using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldScrolling : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    Vector2Int currentTilePosition;
    GameObject[,] terrainTiles;

    [SerializeField] int TerrainTileHorizontalCount;
    [SerializeField] int TerrainTileVerticalCount;

    private void Awake()
    {
        
        terrainTiles = new GameObject[TerrainTileHorizontalCount, TerrainTileVerticalCount];
             
    }
}
