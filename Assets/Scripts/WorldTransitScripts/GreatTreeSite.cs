using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatTreeSite : MonoBehaviour
{   
    public Animator playerAnim;

    void Start()
    {
        playerAnim.SetFloat("direction mem y", 0f);
        playerAnim.SetFloat("direction mem x", 1f);
        AwakeningZone.lastScene = "GreatTreeSite";
    }

}