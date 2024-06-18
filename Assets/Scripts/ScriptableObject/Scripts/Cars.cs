using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class Cars : ScriptableObject
{
    public GameObject[] car;
    public float moveSpeed;
    public float rangeDestroy;
}
