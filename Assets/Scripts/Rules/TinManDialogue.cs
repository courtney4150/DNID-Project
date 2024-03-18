using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TinManDialogue : MonoBehaviour
{
    [SerializeField] private float typingSpeed = 0.05f;
    public TMP_Text tinManDialogue;

    [TextArea]
    [SerializeField] private string[] tinManSentences;
    
    [SerializeField] private GameObject continueButton;

    public int tinManIndex;

    public void Start(){
        StartCoroutine(TypeTinManDialogue());
    }

    private IEnumerator TypeTinManDialogue()
    {
        foreach (char letter in tinManSentences[tinManIndex].ToCharArray())
        {
            tinManDialogue.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

        continueButton.SetActive(true);
    }

    public void ContinueDialogue()
    {
        if(tinManIndex < tinManSentences.Length - 1)
        {
            tinManIndex++;
            tinManDialogue.text = string.Empty;
            StartCoroutine(TypeTinManDialogue());
        }
    }

}
