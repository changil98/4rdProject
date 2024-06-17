using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentManager : MonoBehaviour
{
    public GameObject[] EnvironmentObjArray;
    public Transform ParentTransform = null;

    public int MinPosZ = -20;
    public int MaxPosZ = 20;

    void Start()
    {
        for (int i = MinPosZ; i < MaxPosZ; i++)
        {
            CloneRoad(i);
        }
    }

    void CloneRoad(int p_posz)
    {
        int randomindex = Random.Range(0, EnvironmentObjArray.Length);
        GameObject cloneObj = GameObject.Instantiate(EnvironmentObjArray[randomindex]);

        Vector3 offsetpos = Vector3.zero;
        offsetpos.z = (float)p_posz;
        cloneObj.transform.SetParent(ParentTransform);
        cloneObj.transform.position = offsetpos;

        int randomrot = Random.Range(0, 2);
        if (randomrot == 1)
        {
            cloneObj.transform.rotation = Quaternion.Euler(0, 180f, 0f);
        }
    }
}
