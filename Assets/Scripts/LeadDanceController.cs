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
        InitialGreeting();
        //GameDialog();
    }

    void InitialGreeting()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 10 && withinGreetingDistance)
        {
            withinGreetingDistance = false;
            dialogueTrigger.TriggerDialogue();
        }
    }

    void GameDialog()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.tag == "NPC1")
                {
                    //dialogueTrigger.TriggerDanceGameDialogue();
                }
            }
        }      
    }
}
