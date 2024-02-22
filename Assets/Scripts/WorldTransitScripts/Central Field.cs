using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentralField : MonoBehaviour
{
    public GameObject player;
    public Animator playerAnim;

    void Start()
    {
        if(AwakeningZone.lastScene == "Cave 1"){
            player.transform.position = new Vector2(7.7f, -1.9f);
            playerAnim.SetFloat("direction mem x", -1f);
            playerAnim.SetFloat("direction mem y", 0f);
        }

        AwakeningZone.lastScene = "Central Field";
    }

}
