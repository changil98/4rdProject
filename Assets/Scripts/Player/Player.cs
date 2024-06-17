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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            Debug.Log("���� �ε���");
            //Time.timeScale = 0f;
        }
        else if (other.gameObject.tag == "Water")
        {
            Debug.Log("�ͻ�...");
            //Time.timeScale = 0f;
        }
    }
}
