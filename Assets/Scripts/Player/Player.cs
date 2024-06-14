using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerController controller;

    private void Awake()
    {
        controller = GetComponent<PlayerController>();
    }
}
