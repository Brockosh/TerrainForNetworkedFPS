using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlacementGenerator : MonoBehaviour
{

    [Header("Map to Spawn on")]
    [SerializeField] TerrainGenerator map;

    [Header("TextureData")]
    [SerializeField] TextureData myTextures;

    [Header("SpawnHeights")]
    [SerializeField] float minSpawnHeight;
    [SerializeField] float maxSpawnHeight;

    [Header("Prefab to Spawn")]
    [SerializeField] GameObject prefab;



    float GetRandomValue(float minValue, float maxValue)
    {
        return Random.Range(minValue, maxValue);
    }

}