using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeningZone : MonoBehaviour
{
    public GameObject player;
    public static int lastScene;
    void Start()
    {
        if(lastScene == 1)
            player.transform.position = new Vector2(2.5f, 48.3f);
        lastScene = 0;
    }

}
