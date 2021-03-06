﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GypsyDanceController : MonoBehaviour
{
    Animator animator;
    DialogueTrigger dialogueTrigger;
    public GameObject player;
    bool withinGreetingDistance = true;
    void Start()
    {
        animator = GetComponent<Animator>();
        dialogueTrigger = GetComponent<DialogueTrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 10 && withinGreetingDistance)
        {
            animator.SetBool("snakeDance", true);
            withinGreetingDistance = false;
            dialogueTrigger.TriggerDialogue();
        }
    }
}

