using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LionWin : MonoBehaviour
{
    public void OnButtonPress()
    {
        SceneManager.LoadScene("Transition4toEC");
    }
}
