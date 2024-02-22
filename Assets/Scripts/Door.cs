using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public SpriteRenderer buttonSprite;
    public Animator fadeAnim;
    public bool canInteract = false;
    public string nextScene;

    void Start(){
        buttonSprite.enabled = false;
        fadeAnim.SetBool("isPressed", false);
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.E) && canInteract){
            fadeAnim.SetBool("isPressed", true);
            StartCoroutine(SceneLoadDelay());
        }

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

    IEnumerator SceneLoadDelay(){
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(nextScene);
    }
}
