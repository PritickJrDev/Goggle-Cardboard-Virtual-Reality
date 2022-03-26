using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject player;
    private Vector3 pos;
   
    bool isActive;

    public void TeleportPlayer()
    {
        pos = new Vector3(transform.position.x, transform.position.y + 10f, transform.position.z);
        player.transform.position = pos; 
    }
}
