using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BairdController : MonoBehaviour
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
            animator.SetBool("playGuitar", true);
            withinGreetingDistance = false;
            dialogueTrigger.TriggerDialogue();
        }
    }
}
