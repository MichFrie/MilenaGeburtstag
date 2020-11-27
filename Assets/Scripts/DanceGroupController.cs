using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceGroupController : MonoBehaviour
{
    Animator animator;
   
    bool stopDancing = true;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        DanceSequence();
    }

   
    void DanceSequence()
    {
        if (Input.GetKeyDown(KeyCode.F) && stopDancing)
        {
            animator.SetTrigger("gangnamStyle");
            stopDancing = false;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            animator.SetTrigger("macarena");
        }
    }
}
