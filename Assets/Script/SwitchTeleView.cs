using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwitchTeleView : MonoBehaviour
{
    public Image image;

    public void Update()
    {
        if(image.fillAmount == 1)
        {
            SceneManager.LoadScene("VRMesh");
        }
    }
}
