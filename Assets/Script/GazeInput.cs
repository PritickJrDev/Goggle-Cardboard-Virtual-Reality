using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazeInput : MonoBehaviour
{
    public Image image;
    private bool gazeSwitch;
    public float gazeTimer;
    public float totalTime = 2f;

    public int distanceOfRay = 10000;
    private RaycastHit _hit;

    private void Update()
    {
        if (gazeSwitch)
        {
            gazeTimer += Time.deltaTime;
            image.fillAmount = gazeTimer / totalTime;
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        if (Physics.Raycast(ray, out _hit, distanceOfRay))
        {
            if (image.fillAmount == 1 && _hit.transform.CompareTag("TeleportObject"))
            {
                _hit.transform.gameObject.GetComponent<Teleport>().TeleportPlayer();
            } 

        }

    }

    public void GazeOn()
    {
        gazeSwitch = true;
    }

    public void GazeOf()
    {
        gazeSwitch = false;
        gazeTimer = 0;
        image.fillAmount = 0;
    }
}
