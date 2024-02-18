using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    private Rigidbody2D mainplayer;
    public float moveHorizontal, moveVertical;
    public float speed = 5f;

    void Start(){
        mainplayer = gameObject.GetComponent<Rigidbody2D>();
    }

    
    void Update(){
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate(){
        Vector2 movement = new Vector2(speed*moveHorizontal, speed*moveVertical);
        movement.Normalize();
        mainplayer.velocity = movement;
    }

}
