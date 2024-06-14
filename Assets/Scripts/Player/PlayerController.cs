using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    private bool move = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && move == false)
        {
            move = true;

            transform.Translate(new Vector3(0, 0, 1));

            if (transform.GetChild(0).rotation.y != 0)
            {
                transform.GetChild(0).rotation = Quaternion.Euler(0, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.S) && move == false)
        {
            move = true;

            transform.Translate(new Vector3(0, 0, -1));

            if (transform.GetChild(0).rotation.y != 180)
            {
                transform.GetChild(0).rotation = Quaternion.Euler(0, 180, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.A) && move == false)
        {
            move = true;

            transform.Translate(new Vector3(-1, 0, 0));

            if (transform.GetChild(0).rotation.y != -90)
            {
                transform.GetChild(0).rotation = Quaternion.Euler(0, -90, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.D) && move == false)
        {
            move = true;

            transform.Translate(new Vector3(1, 0, 0));

            if (transform.GetChild(0).rotation.y != 90)
            {
                transform.GetChild(0).rotation = Quaternion.Euler(0, 90, 0);
            }
        }

        move = false;
    }
}
