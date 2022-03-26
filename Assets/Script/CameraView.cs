using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour
{
    public float mouseSensitivity;
    private float mouseX, mouseY;
    public Transform player;
    private float xRotate = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //locking the mouse cursor to prevent out of screen bound
    }

    void Update()
    {
        xyMovement();
    }

    private void xyMovement()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; //horizontal axis of a mouse
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; //vertical axis of a mouse

        xRotate -= mouseY; 
        xRotate = Mathf.Clamp(xRotate, -90f, 90f); //clamping the vertical axis into certain degree

        transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f); //the rotation of a camera in y axis
        player.Rotate(Vector3.up * mouseX);
    }
}
