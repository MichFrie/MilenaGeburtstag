using UnityEngine;

public class DanceGroupController : MonoBehaviour
{
    Animator animator;
    ClickableText clickableText;
    bool canPlayAudio = true;
    bool canPlayAnimation = true;
    int count = 1;


    void Start()
    {
        animator = GetComponent<Animator>();
        clickableText = ClickableText.instance;  

    }

    void Update()
    {
        //DanceSequence();
    }


    public void DanceSequence()
    {
        if (clickableText.linkIndex == 0)
        {
            switch (count)
            {
                case 1:
                    {
                        if (canPlayAnimation)
                        {
                            animator.SetTrigger("gangnamStyle");
                            canPlayAnimation = false;
                        }
                        
                        if (canPlayAudio)
                        {
                            FindObjectOfType<AudioManager>().PlayAudio("gangnamStyle");
                            canPlayAudio = false;
                        }
                        count++;
                        break;
                    }
                case 2:
                    {
                        if (canPlayAnimation)
                        {
                            animator.SetTrigger("ymca");
                            canPlayAnimation = false;
                        }

                        if (canPlayAudio)
                        {
                            FindObjectOfType<AudioManager>().PlayAudio("MainTheme");
                            canPlayAudio = false;
                        }
                        count++;
                        break;
                    }
            }
        }
    }

    public void ResetBools()
    {
        canPlayAnimation = true;
        canPlayAudio = true;
    }
}
