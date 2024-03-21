using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DorothyWinButton : MonoBehaviour
{
    public void OnButtonPress()
    {
        SceneManager.LoadScene("Transition1to2");
    }
}
