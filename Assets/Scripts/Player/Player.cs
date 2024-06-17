using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerController controller;
    private Animator animator;

    public GameObject gameover;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Boat")
            transform.SetParent(collision.gameObject.transform);
        else
            transform.SetParent(null);
    }

    private void GameOver()
    {
        Time.timeScale = 0f;
        gameover.SetActive(true);
    }
}
