using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cave1 : MonoBehaviour
{
    public GameObject player;
    public Animator playerAnim;

    void Start()
    {
        if(AwakeningZone.lastScene == 0){
            player.transform.position = new Vector2(0.5f, -1f);
            playerAnim.SetFloat("direction mem y", 1f);
        }

        if(AwakeningZone.lastScene == 2){
            player.transform.position = new Vector2(-13.7f, 63f);
            playerAnim.SetFloat("direction mem x", 1f);
        }

        AwakeningZone.lastScene = 1;
    }

}
