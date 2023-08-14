using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnToLookByPositionSubstraction : MonoBehaviour
{
    public Transform targetTr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion lookRotation = Quaternion.LookRotation(targetTr.position - transform.position);
        transform.rotation = lookRotation;
    }
}
