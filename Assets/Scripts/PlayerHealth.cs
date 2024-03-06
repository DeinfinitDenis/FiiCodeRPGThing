using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static int maxHearts = 4;
    public static int health = 4;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public Image bowUI;
    public Image swordUI;

    void Update()
    {   
        
        if(Input.GetKeyDown(KeyCode.P))
            health++;

        if(Input.GetKeyDown(KeyCode.O))
            health--;

        if(Input.GetKeyDown(KeyCode.L))
            maxHearts++;

        if(Input.GetKeyDown(KeyCode.K))
            maxHearts--;

        if(health > maxHearts){
            health = maxHearts;
        }

        if(PlayerActions.weaponslot == 1){
            bowUI.enabled = false;
            swordUI.enabled = true;
        }
        else if(PlayerActions.weaponslot == 2){
            bowUI.enabled = true;
            swordUI.enabled = false;
        }

        for(int i = 0; i < hearts.Length; i++){
            if(i < health)
                hearts[i].sprite = fullHeart;
            else hearts[i].sprite = emptyHeart;

            if(i < maxHearts)
                hearts[i].enabled = true;
            else hearts[i].enabled = false;
        }
    }
}
