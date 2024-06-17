using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
    public List<Transform> EnvirmentObjectList = new List<Transform>();
    private int StartMinVal = -12;
    private int StartMaxVal = 12;

    private int SpawnCreateRandom = 30;

    void Start()
    {
        GeneratorEnvirment();
    }

    void GeneratorEnvirment()
    {
        Vector3 spawnPos = Vector3.zero;

        for (int i = StartMinVal; i < StartMaxVal; i++)
        {
            int randomNum = Random.Range(0, 100);
            if (randomNum < SpawnCreateRandom)
            {
                int randomindex = Random.Range(0, EnvirmentObjectList.Count);
                GameObject tempclone = Instantiate(EnvirmentObjectList[randomindex].gameObject);
                spawnPos.Set(i, 0.5f, 0f);

                tempclone.transform.SetParent(this.transform);
                tempclone.transform.localPosition = spawnPos;
            }
        }
    }
}
