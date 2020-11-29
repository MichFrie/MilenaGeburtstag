using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public Text dialogueText;

    public Animator animator;
    public Animator gameAnimator;

    void Start()
    {

        sentences = new Queue<string>();
        animator.SetBool("gameCanvas", false);
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("isOpen", true);
        
       
        sentences.Clear();
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        animator.SetBool("isOpen", false);
        Debug.Log("End of conversation");
    }

    public void StartDanceGameDialogue(Dialogue dialogue)
    {
        gameAnimator.SetBool("gameCanvas", true);
        
    }

    void GameMechanic()
    {
        //GameObject.FindGameObjectWithTag("AnswerBox1").GetComponent<TextMeshProUGUI>().text = "";
        //GameObject.FindGameObjectWithTag("AnswerBox2").SetActive(true);
    }
}
