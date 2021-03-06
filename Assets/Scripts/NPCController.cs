﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
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

    void Update()
    {
        NPC1Greeting();
    }

    void NPC1Greeting()
    {
        if(Vector3.Distance(transform.position, player.transform.position) < 10 && withinGreetingDistance)
        {
            animator.SetTrigger("wavingTrigger");
            dialogueTrigger.TriggerDialogue();
            withinGreetingDistance = false;

        }
    }
}
