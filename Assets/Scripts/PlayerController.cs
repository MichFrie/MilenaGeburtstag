﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float sprintMultiplier = 1.5f;

    Rigidbody rb;
    Animator animator;

    LeadDanceController leadDanceController;

    public bool isMoving = false;
    public float turnSpeed = 50f;

    void Start()
    {
        //FindObjectOfType<AudioManager>().PlayAudio("MainTheme");
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        leadDanceController = GetComponent<LeadDanceController>();
    }

    void Update()
    {
        Movement();
        
    }

    void Movement()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if (x != 0 || z != 0)
        {
            isMoving = true;
            float actualSpeed = speed;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                actualSpeed *= sprintMultiplier;
            }

            Vector3 moveBy = transform.right * x + transform.forward * z;
            rb.MovePosition(transform.position + moveBy.normalized * actualSpeed * Time.deltaTime);
            animator.SetBool("isRunning", true);
        }
        else
        {
            isMoving = false;
            animator.SetBool("isRunning", false);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }

    }

}
