using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public CubeColorData[] availableColors;
    [SerializeField] GameObject cubePrefab;

    private void Start()
    {
        CubeSpawn();
    }

    private void SpawnCube()
    {
        CubeSpawn();
    }

    void CubeSpawn()
    {
        int randomIndex = UnityEngine.Random.Range(0, availableColors.Length);
        Color randomColor = availableColors[randomIndex].cubeColor;

        Debug.Log("Spawned cube color: " + randomColor);

        GameObject cube = Instantiate(cubePrefab, new Vector3(UnityEngine.Random.Range(-5f, 5f), UnityEngine.Random.Range(-1f, 4f), 0f), Quaternion.identity);
        cube.GetComponent<Renderer>().material.color = randomColor;

        Debug.Log("Cube Spawned");
    }

    private void OnEnable()
    {
        Cube.OnCubeDestroy += SpawnCube;
    }
    private void OnDisable()
    {
        Cube.OnCubeDestroy -= SpawnCube;
    }


}
