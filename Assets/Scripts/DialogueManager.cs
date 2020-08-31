﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    //public Dialogue dialogue;

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        
    }

    public void StartDialogue(Dialogue dialogue) 
    {
        Debug.Log("Starting conversation with " + dialogue.name);
        
        //Debug.Log("Starting conversation with " + nameText.name);
        //Debug.Log("Starting conversation with " + dialogue.name); 
        nameText = GameObject.Find("Name").GetComponent<Text>();
        dialogueText = GameObject.Find("Dialog").GetComponent<Text>();
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            Debug.Log("adding " + sentence);
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        Debug.Log("sentence count: " + sentences.Count);
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        //Debug.Log(sentence);
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {
        Debug.Log("End of conversation.");
    }
}
