using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{

    private AudioSource audioSource;//Walk sounds chestie nebunie

    private Rigidbody2D mainplayer;
    public float moveHorizontal, moveVertical;
    public float speed = 5f;

    public bool isSlash = false;
    public BoxCollider2D slashBox;
    public SpriteRenderer slashSprite;

    void Start(){
        mainplayer = gameObject.GetComponent<Rigidbody2D>();
        audioSource = gameObject.GetComponent<AudioSource>();
        slashBox.enabled = false;
        slashSprite.enabled = false;
    }

    
    void Update(){
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");

        if(Input.GetMouseButtonDown(0)){
            if(!isSlash)
                StartCoroutine(SlashDelay());
        }

    }

    void FixedUpdate(){
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        movement.Normalize();
        if((movement.x != 0 || movement.y != 0 )&& !audioSource.isPlaying)audioSource.Play();
        else if((movement.x == 0 && movement.y == 0) && audioSource.isPlaying)audioSource.Stop();
        mainplayer.velocity = movement * speed;
    }

    IEnumerator SlashDelay(){
        isSlash = true;
        slashBox.enabled = true;
        slashSprite.enabled = true;
        yield return new WaitForSeconds(0.5f);
        isSlash = false;
        slashBox.enabled = false;
        slashSprite.enabled = false;
    }

}
