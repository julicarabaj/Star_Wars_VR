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
        laser .transform.localScale = new Vector3(fullSize.x, 0, fullSize.z); 
    }


    void Update()
    {
        GetInput();
        lasersControll();
    }

    private void lasersControll()
    {
        if (activate && laser.transform.localScale.y < fullSize.y)
        {
            laser.SetActive(true);
            laser.transform.localScale += new Vector3(0, 0.0001f, 0);
        }
        else if (activate == false && laser.transform.localScale.y >= 0)
        {
            laser.transform.localScale += new Vector3(0, -0.0001f, 0);
        }
        else if (activate == false && laser.transform.localScale.y >= 0)
        {
            laser.SetActive(false);
        }
    }
    private void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            activate = !activate;
            Debug.Log("boton");
        }
    }
    
}
