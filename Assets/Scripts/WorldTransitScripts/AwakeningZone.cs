using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeningZone : MonoBehaviour
{
    public GameObject player;
    public Animator playerAnim;
    public static string lastScene;
    void Start()
    {
        if(lastScene == "Cave 1"){
            player.transform.position = new Vector2(2.5f, 48.3f);
            playerAnim.SetFloat("direction mem y", -1f);
            playerAnim.SetFloat("direction mem x", 0f);
        }
        else{
            playerAnim.SetFloat("direction mem y", 1f);
            playerAnim.SetFloat("direction mem x", 0f);
        }
        lastScene = "AwakeningSite";
    }

}
