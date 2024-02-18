using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    //player movement

    ////////////////////////////ce a adaugat denis
    private AudioSource audioSource;//Walk sounds chestie nebunie
    ///////////////////////////////

    private Rigidbody2D mainplayer;
    public float moveHorizontal, moveVertical;
    public float speed = 10f;

    //slash skill
    public bool isSlash = false;
    public bool isArrow = false;
    public GameObject slash;

    //Bow Weapon
    public GameObject arrow;
    public float arrowSpeed = 40f;

    //other
    public int weaponslot = 1;
    public int dx, dy;

    void Start(){
        mainplayer = gameObject.GetComponent<Rigidbody2D>();
        slash.SetActive(false);
        mainplayer.transform.eulerAngles = new Vector3(0f, 0f, 180f);
        dx = 0;
        dy = -1;
        ////////////////////ce a adaugat denis
        audioSource = gameObject.GetComponent<AudioSource>();
        //slashBox.enabled = false;
        //slashSprite.enabled = false;
        //////////////////////////////////////////////////////
    }

    
    void Update(){
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");

        if(!isSlash)
            DirectionCode();
        
        if(Input.GetMouseButtonDown(0)){
            if(weaponslot == 1){
                if(!isSlash)
                    SlashCode();    
            }
            else{
                if(!isArrow){
                    ArrowCode();
                }
                    
            }
        }

        if(Input.GetKey(KeyCode.Alpha1))
            weaponslot = 1;
        else if(Input.GetKey(KeyCode.Alpha2))
            weaponslot = 2;

    }

    void FixedUpdate(){
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        movement.Normalize();

        if(!isSlash){
            mainplayer.velocity = movement * speed;
        }
        else mainplayer.velocity = new Vector2(0f, 0f);

        ////////////////////////////ce a adaugat denis
        if((movement.x != 0 || movement.y != 0 )&& !audioSource.isPlaying)audioSource.Play();
        else if((movement.x == 0 && movement.y == 0) && audioSource.isPlaying)audioSource.Stop();
        mainplayer.velocity = movement * speed;
        //////////////////////////////////
    }

    void DirectionCode(){
        if(Input.GetKey(KeyCode.A)){
            mainplayer.transform.eulerAngles = new Vector3(0f, 0f, -90f);
            dx = -1;
            dy = 0;
        }
        if(Input.GetKey(KeyCode.D)){
            mainplayer.transform.eulerAngles = new Vector3(0f, 0f, 90f);
            dx = 1;
            dy = 0;
        }
        if(Input.GetKey(KeyCode.W)){
            mainplayer.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            dx = 0;
            dy = 1;
        }
        if(Input.GetKey(KeyCode.S)){
            mainplayer.transform.eulerAngles = new Vector3(0f, 0f, 180f);
            dx = 0;
            dy = -1;
        }
    }

    //Slash Skill
    void SlashCode(){
        StartCoroutine(SlashDelay());
        slash.transform.position = new Vector2(mainplayer.transform.position.x + dx, mainplayer.transform.position.y + dy);
        slash.transform.eulerAngles = new Vector3(0f, 0f, mainplayer.rotation);
        
    }
    
    IEnumerator SlashDelay(){
        isSlash = true;
        slash.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        slash.SetActive(false);
        isSlash = false;

    }

    //Arrow
    void ArrowCode(){
        Vector2 direction = new Vector2(dx, dy);
        var harrow = Instantiate(arrow, mainplayer.transform.position, mainplayer.transform.rotation);
        harrow.GetComponent<Rigidbody2D>().velocity = direction * arrowSpeed;
        StartCoroutine(ArrowDelay());
        Destroy(harrow, 0.7f);
    }

    IEnumerator ArrowDelay(){
        isArrow = true;
        yield return new WaitForSeconds(0.7f);
        isArrow = false;
    }
}
