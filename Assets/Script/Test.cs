using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int distanceOfRay = 10000;
    private RaycastHit _hit;

    private void Update()
    { 
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        if (Physics.Raycast(ray, out _hit, distanceOfRay))
        {
            if ( _hit.transform.CompareTag("TeleportObject"))
            {
                _hit.transform.gameObject.GetComponent<test2>().TeleportPlayer();
                Debug.Log("Working");
            }

        }

    }
}
