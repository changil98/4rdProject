using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public LayerMask objLayerMask;

    private bool move = false;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && move == false)
        {
            if (Physics.Raycast(transform.position + (transform.up * 0.5f), Vector3.forward, 1f, objLayerMask))
            {
                Debug.Log("´ê¾Ò´Ù.");
                return;
            }
            else
            {
                move = true;

                StartCoroutine("JumpAni");

                transform.Translate(new Vector3(0, 0, 1));

                if (transform.GetChild(0).rotation.y != 0)
                {
                    transform.GetChild(0).rotation = Quaternion.Euler(0, 0, 0);
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.S) && move == false)
        {
            if (Physics.Raycast(transform.position + (transform.up * 0.5f), Vector3.back, 1f, objLayerMask))
            {
                Debug.Log("´ê¾Ò´Ù.");
                return;
            }
            else
            {
                move = true;

                StartCoroutine("JumpAni");

                transform.Translate(new Vector3(0, 0, -1));

                if (transform.GetChild(0).rotation.y != 180)
                {
                    transform.GetChild(0).rotation = Quaternion.Euler(0, 180, 0);
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.A) && move == false)
        {
            if (Physics.Raycast(transform.position + (transform.up * 0.5f), Vector3.left, 1f, objLayerMask))
            {
                Debug.Log("´ê¾Ò´Ù.");
                return;
            }
            else
            {
                move = true;

                StartCoroutine("JumpAni");

                transform.Translate(new Vector3(-1, 0, 0));

                if (transform.GetChild(0).rotation.y != -90)
                {
                    transform.GetChild(0).rotation = Quaternion.Euler(0, -90, 0);
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.D) && move == false)
        {
            if (Physics.Raycast(transform.position + (transform.up * 0.5f), Vector3.right, 1f, objLayerMask))
            {
                Debug.Log("´ê¾Ò´Ù.");
                return;
            }
            else
            {
                move = true;

                StartCoroutine("JumpAni");

                transform.Translate(new Vector3(1, 0, 0));

                if (transform.GetChild(0).rotation.y != 90)
                {
                    transform.GetChild(0).rotation = Quaternion.Euler(0, 90, 0);
                }
            }
        }

        move = false;
    }

    IEnumerator JumpAni()
    {
        animator.SetBool("Jump", true);
        yield return new WaitForSeconds(0.2f);
        animator.SetBool("Jump", false);
    }
}
