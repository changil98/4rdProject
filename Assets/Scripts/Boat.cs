using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    private float MoveSpeed = 2f;
    private float RangeDestroy = 12;

    void Start()
    {
        
    }

    // Update is called once per frame
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
