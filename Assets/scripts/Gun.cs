using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;


public class Gun : MonoBehaviour
{

    public GameObject bullet;
    public AudioSource audio;
    public ParticleSystem flash;
    public float range = 100f;

    public Image leftReticle;
    public Image bottomReticle;
    public Image topReticle;
    public Image rightReticle;
    private Image[] Images = new Image[5];

    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        Images =(Image[]) GetComponents<Image>();

        audio = GetComponent<AudioSource>();
        leftReticle =(Image) Images[0];
        rightReticle = (Image)Images[1];
        topReticle = (Image)Images[2];
        bottomReticle = (Image)Images[3];

      
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            if (hit.transform.tag == "enemy")
            {
                leftReticle.color = Color.red;
                rightReticle.color = Color.red;
                topReticle.color = Color.red;
                bottomReticle.color = Color.red;
            }
            else
            {
                leftReticle.color = Color.white;
                rightReticle.color = Color.white;
                topReticle.color = Color.white;
                bottomReticle.color = Color.white;
            }
        }


        if (Input.GetMouseButtonDown(0))
        {
           // GameObject newbullet = Instantiate(bullet);
            GameObject newbullet = ObjectPool.sharedInstance.getPooledObjects();
            newbullet.transform.position = transform.position + transform.up;
            newbullet.GetComponent<Rigidbody>().velocity = transform.up*18f;
            audio.Play();
            flash.Play();
            newbullet.SetActive(true);
        }
        
    }
}
