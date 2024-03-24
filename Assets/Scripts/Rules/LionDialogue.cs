using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LionDialogue : MonoBehaviour
{
    [SerializeField] private float typingSpeed = 0.05f;
    public TMP_Text lionDialogue;

    [TextArea]
    [SerializeField] private string[] lionSentences;
    
    [SerializeField] private GameObject continueButton;

    public int lionIndex;

    public void Start(){
        StartCoroutine(TypeLionDialogue());
    }

    private IEnumerator TypeLionDialogue()
    {
        foreach (char letter in lionSentences[lionIndex].ToCharArray())
        {
            lionDialogue.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

        continueButton.SetActive(true);
    }

    public void ContinueDialogue()
    {
        if(lionIndex < lionSentences.Length - 1)
        {
            lionIndex++;
            lionDialogue.text = string.Empty;
            StartCoroutine(TypeLionDialogue());
        }
        else
        {
            SceneManager.LoadScene("Level4");
        }
    }

}
