using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    public GameObject lockedDoor;
    public GameObject unlockedDoor;
    public GameObject spriteLocked;
    public GameObject spriteUnlocked;

    void Start()
    {
        if(StaticVariables.Cave1DoorIsUnlocked){
            lockedDoor.SetActive(false);
            unlockedDoor.SetActive(true);
            spriteLocked.SetActive(false);
            spriteUnlocked.SetActive(true);
        }

        else{
            lockedDoor.SetActive(true);
            unlockedDoor.SetActive(false);
            spriteLocked.SetActive(true);
            spriteUnlocked.SetActive(false);
        }
    }
}
