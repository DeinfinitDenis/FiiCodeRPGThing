using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSfx : MonoBehaviour
{
    public AudioSource playerFootsteps;
    public Animator playerAnim;

    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) && !playerAnim.GetBool("isAttack")){
            playerFootsteps.enabled = true;
        }
        else playerFootsteps.enabled = false;
    }
}
