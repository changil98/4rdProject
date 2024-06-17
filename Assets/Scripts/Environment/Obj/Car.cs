using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private float MoveSpeed = 2f;
    private float RangeDestroy = 12;

    void Update()
    {
        float moveX = MoveSpeed * Time.deltaTime;
        transform.Translate(moveX, 0f, 0f);

        if (transform.localPosition.x >= RangeDestroy)
        {
            Destroy(gameObject);
        }
    }
}
