using UnityEngine;

public class DanceGroupController : MonoBehaviour
{
    Animator animator;
    int count = 1;

    void Start()
    {
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        DanceSequence();
    }


    public void DanceSequence()
    {
        if (FindObjectOfType<ClickableText>().linkIndex == 0)
        {
            switch (count)
            {
                case 1: animator.SetBool("gangnamStyle", true); count++; break;
                case 2: animator.SetTrigger("ymca"); count++; break;
            }
        }
    }
}
