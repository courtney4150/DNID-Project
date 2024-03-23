using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScarecrowDialogue : MonoBehaviour
{
    [SerializeField] private float typingSpeed = 0.05f;
    public TMP_Text scarecrowDialogue2;

    [TextArea]
    [SerializeField] private string[] ScarecrowSentences;
    
    [SerializeField] private GameObject continueButton;

    public int scarecrowIndex;

    public void Start(){
        StartCoroutine(TypeScarecrowDialogue());
    }

    private IEnumerator TypeScarecrowDialogue()
    {
        foreach (char letter in ScarecrowSentences[scarecrowIndex].ToCharArray())
        {
            scarecrowDialogue2.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

        continueButton.SetActive(true);
    }

    public void ContinueDialogue()
    {
        if(scarecrowIndex < ScarecrowSentences.Length - 1)
        {
            scarecrowIndex++;
            scarecrowDialogue2.text = string.Empty;
            StartCoroutine(TypeScarecrowDialogue());
        }
    }
}
