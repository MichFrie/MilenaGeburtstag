using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeadDanceController : MonoBehaviour
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
        if (Vector3.Distance(transform.position, player.transform.position) < 10 && withinGreetingDistance)
        {
          
            withinGreetingDistance = false;
            dialogueTrigger.TriggerDialogue();
        }
    }
}
