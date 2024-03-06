using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleSite : MonoBehaviour
{   
    public Animator playerAnim;
    public GameObject player;
    
    void Start()
    {
        if(AwakeningZone.lastScene == "Central Field"){
            player.transform.position = new Vector2(0f, 0f);
            playerAnim.SetFloat("direction mem x", 0f);
            playerAnim.SetFloat("direction mem y", 1f);
        }
        if(AwakeningZone.lastScene == "SnowZone"){}
        if(AwakeningZone.lastScene == "Canyon"){}
        if(AwakeningZone.lastScene == "Village"){}
        if(AwakeningZone.lastScene == "Other"){}

         AwakeningZone.lastScene = "Castle Field";
    }
    
}