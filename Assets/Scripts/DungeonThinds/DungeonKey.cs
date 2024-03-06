using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonKey : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(door);
        Destroy(gameObject);
    }
}
