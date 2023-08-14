using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnToLookAt : MonoBehaviour
{
    public Transform targetTR;

    // Update is called once per frame
    void Update()
    {
        Vector3 currentEulerAngles = transform.eulerAngles;
        transform.LookAt(targetTR);
        transform.eulerAngles = new Vector3(currentEulerAngles.x,transform.eulerAngles.y,currentEulerAngles.z);
    }
}
