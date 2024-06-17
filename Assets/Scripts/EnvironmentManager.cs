using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentManager : MonoBehaviour
{
    public GameObject[] MapPrefabs;

    private Transform playerTransform;
    private float spawnZ = 1.0f;
    private float MapLength = 1.0f;
    private float safeZone = 15.0f;
    private int amountMapsOnScreen = 40;

    private List<GameObject> activeMaps;
    private GameObject startMap;

    void Start()
    {
        activeMaps = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        startMap = GameObject.FindGameObjectWithTag("StartMap");

        for (int i = 0; i < amountMapsOnScreen; i++)
        {
            CloneMap();
        }
    }

    private void Update()
    {
        if (playerTransform.position.z - safeZone > (spawnZ - amountMapsOnScreen * MapLength))
        {
            CloneMap();
            DestroyMap();
        }
    }

    void CloneMap(int prefabIndex = -1)
    {
        GameObject gameObject;
        int randomIndex = Random.Range(0, MapPrefabs.Length);
        gameObject = Instantiate(MapPrefabs[randomIndex]);
        gameObject.transform.SetParent(transform);
        gameObject.transform.position = Vector3.forward * spawnZ;
        spawnZ += MapLength;

        int randomRot = Random.Range(0, 2);
        if (randomRot == 1)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 180f, 0f);
        }

        activeMaps.Add(gameObject);
    }

    void DestroyMap()
    {
        Destroy(startMap);
        Destroy(activeMaps[0]);
        activeMaps.RemoveAt(0);

    }
}
