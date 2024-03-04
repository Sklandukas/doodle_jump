using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public int numberOfPlatforms = 300;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;

    void Start()
    {
        Vector3 spawnPosition = new Vector3(0, -6, 0); 

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth); 

            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
