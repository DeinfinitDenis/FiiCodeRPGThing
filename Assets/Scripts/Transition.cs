using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public Animator fadeAnim;
    public string nextScene;

    void Start(){
        fadeAnim.SetBool("isPressed", false);
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            fadeAnim.SetBool("isPressed", true);
            StartCoroutine(SceneLoadDelay());
        }
    }

    IEnumerator SceneLoadDelay(){
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(nextScene);
    }
}

