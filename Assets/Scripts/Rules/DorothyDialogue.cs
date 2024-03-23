using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DorothyDialogue : MonoBehaviour
{
    [SerializeField] private float typingSpeed = 0.05f;
    public TMP_Text dorothyDialogue;

    [TextArea]
    [SerializeField] private string[] DorothySentences;
    
    [SerializeField] private GameObject continueButton;

    public int dorothyIndex;

    public void Start(){
        StartCoroutine(TypeDorothyDialogue());
    }

    private IEnumerator TypeDorothyDialogue()
    {
        foreach (char letter in DorothySentences[dorothyIndex].ToCharArray())
        {
            dorothyDialogue.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

        continueButton.SetActive(true);
    }

    public void ContinueDialogue()
    {
        if(dorothyIndex < DorothySentences.Length - 1)
        {
            dorothyIndex++;
            dorothyDialogue.text = string.Empty;
            StartCoroutine(TypeDorothyDialogue());
        }
        else
        {
            SceneManager.LoadScene("Level1");
        }
    }
}

