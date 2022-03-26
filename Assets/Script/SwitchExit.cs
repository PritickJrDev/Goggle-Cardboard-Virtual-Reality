using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwitchExit : MonoBehaviour
{
    public Image image;

    public void Update()
    {
        if(image.fillAmount == 1)
       {
            Application.Quit();
            Debug.Log("exiting");
       }
    }
}
