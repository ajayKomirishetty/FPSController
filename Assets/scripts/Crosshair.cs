using System;
using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
//using System.Diagnostics;
using UnityEngine;

public class Crosshair : MonoBehaviour
{


    public RectTransform reticle;

    public float restingSize;
    public float zoomSize;
    public float speed;
    private float currSize;
    public float distance = 10f;



    private Color initialColor = Color.yellow;
    private Color finalColor = Color.red;

    public Camera cam;


    bool isMoving
    {
        get
        {
            if (
                Input.GetAxis("Horizontal") != 0 ||
                Input.GetAxis("Vertical") != 0 ||
                Input.GetAxis("Mouse X") != 0 ||
                Input.GetAxis("Mouse Y") != 0
                )

                return true;
            else
                return false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        reticle = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 origin = transform.position;
        Vector3 direction = transform.up;
        Debug.DrawRay(origin, direction * 10f, Color.red);

        //Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        // Debug.DrawRay(transform.position, forward, Color.green);
       // Ray ray = new Ray(origin, direction);
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 100))
        {
            // rayCastHit.collider.GetComponent<Renderer>().material.color = Color.red;
            Debug.DrawRay(cam.transform.position, cam.transform.forward, Color.green);
            distance = hit.distance;
            Debug.Log(distance);

        }
        //   reticle.sizeDelta = new Vector2(size,size);
        if (distance > 10)
        {
            currSize = Mathf.Lerp(currSize, zoomSize, Time.deltaTime * speed);
        }
        else
        {
            currSize = Mathf.Lerp(currSize, restingSize, Time.deltaTime * speed);
        }
        reticle.sizeDelta = new Vector2(currSize, currSize);
    }
}
