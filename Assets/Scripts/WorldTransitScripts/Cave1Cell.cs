using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cave1Cell : MonoBehaviour
{   
    public Animator playerAnim;

    void Start()
    {
        playerAnim.SetFloat("direction mem y", 1f);
        playerAnim.SetFloat("direction mem x", 0f);
        AwakeningZone.lastScene = "Cave1Cell";
    }

}