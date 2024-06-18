using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Cars cars;

    void Update()
    {
        float moveX = cars.moveSpeed * Time.deltaTime;
        transform.Translate(moveX, 0f, 0f);

        if (transform.localPosition.x >= cars.rangeDestroy)
        {
            Destroy(gameObject);
        }
    }
}
