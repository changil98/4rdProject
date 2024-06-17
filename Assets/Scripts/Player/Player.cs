using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerController controller;

    public GameObject gameover;

    public Animator animator;

    private void Awake()
    {
        controller = GetComponent<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            animator.SetBool("Crash", true);
            Debug.Log("Â÷¿¡ ºÎµúÈû");

            Invoke("GameOver", 0.5f);
        }
        else if (other.gameObject.tag == "Water")
        {
            Debug.Log("ÀÍ»ç...");

            Invoke("GameOver", 0.1f);
        }
    }

    private void GameOver()
    {
        Time.timeScale = 0f;
        gameover.SetActive(true);
    }
}
