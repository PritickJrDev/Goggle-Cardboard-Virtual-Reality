using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Image image;
    bool FreeViewActive;
    bool QuitAppActive;
    bool droneViewActive;
    bool backButtonActive;

    private string teleportView = "VRMesh";
    private string droneView = "DroneView";
    private string menuView = "Menu";

    private void Start()
    {
        FreeViewActive = false;
        QuitAppActive = false;
        droneViewActive = false;
        backButtonActive = false;
    }

    void Update()
    {
        if (image.fillAmount == 1 && FreeViewActive)
        {
            SceneManager.LoadScene(teleportView);
            FreeViewActive = false;
        }

        if (image.fillAmount == 1 && QuitAppActive)
        {
            Application.Quit();
            QuitAppActive = false;
        }

        if (image.fillAmount == 1 && droneViewActive)
        {
            SceneManager.LoadScene(droneView);
            droneViewActive = false;
        }

        if (image.fillAmount == 1 && backButtonActive)
        {
            SceneManager.LoadScene(menuView);
            backButtonActive = false;
        }
    }

    public void ChangeScene()
    {
            FreeViewActive = true;
    }

    public void QuitApplication()
    {
        QuitAppActive = true;
    }

    public void SceneDroneView()
    {
        droneViewActive = true;
    }

    public void BackToMenu()
    {
        backButtonActive = true;
    }
}