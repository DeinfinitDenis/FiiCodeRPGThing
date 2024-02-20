using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public SpriteRenderer buttonSprite;
    public GameObject dialogue;
    public bool canInteract = false;
    
    void Start(){
        buttonSprite.enabled = false;
        dialogue.SetActive(false);
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.E) && canInteract && dialogue.activeSelf == false)
            dialogue.SetActive(true);
        else if(!canInteract || (Input.GetKeyDown(KeyCode.E) && dialogue.activeSelf == true))
            dialogue.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            buttonSprite.enabled = true;
            canInteract = true;
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            buttonSprite.enabled = false;
            canInteract = false;
        }
    }
}
