using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class LifeCount : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public Sprite emptyMan; 
    public Sprite fullMan;
    public Image[] lives;

    public TinManController tinMan;

    public void LoseLife(){
        
    }

    void Update()
    {
        health = tinMan.health;
        maxHealth =tinMan.maxHealth;

        for  (int i = 0; i < lives.Length; i++)
        {
            if(i<health)
            {
                lives[i].sprite = fullMan;
            }
            else{
                lives[i].sprite = emptyMan;
            }

            if(i<maxHealth)
            {
                lives[i].enabled=true;
            }
            else
            {
                lives[i].enabled=false;
            }
        }
    }
}
