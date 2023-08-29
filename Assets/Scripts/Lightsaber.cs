using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightsaber : MonoBehaviour
{
    
    public OVRInput.Controller controller;
    private bool activate = false;
    private GameObject laser;
    private Vector3 fullSize;

    void Start()
    {
        laser = transform.Find("SingleLine-TextureAdditive").gameObject;
        fullSize = laser.transform.localScale;
        laser   .transform.localScale = new Vector3(fullSize.x, 0, fullSize.z); 
    }


    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One, controller))
        {
            activate = !activate;      
        }
        if (activate && laser.transform.localScale.y < fullSize.y)
        {
            laser.transform.localScale += new Vector3(0, 0.0001f, 0);
        }
        else if (activate == false && laser.transform.localScale.y >= 0)
        {
            laser.transform.localScale += new Vector3(0, -0.0001f, 0);
        }
    }
    
}
