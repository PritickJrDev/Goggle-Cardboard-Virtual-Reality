using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{
    public GameObject cube;

    public void TeleportPlayer()
    {
        cube.transform.position = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);
    }
}
