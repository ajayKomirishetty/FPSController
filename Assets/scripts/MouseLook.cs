using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; // Get the player's co ordinates in x-axis
        float y = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;  // Get the player's co ordinates in x-axis
        playerBody.Rotate(Vector3.up * x);
        xRotation -= y;
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); //Quaternion is unity representation of rotation, and we are moving the object in euler angles 
    }
}

