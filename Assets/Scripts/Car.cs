using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private float MoveSpeed = 2f;
    private float RangeDestroy = 12;

    void Start()
    {
        
    }

    void Update()
    {
        float moveX = MoveSpeed * Time.deltaTime;
        this.transform.Translate(moveX, 0f, 0f);

        if (this.transform.localPosition.x >= RangeDestroy)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
