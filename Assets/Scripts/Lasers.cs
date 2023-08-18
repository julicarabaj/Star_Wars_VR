using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasers : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    void Start()
    {
        //OnCollisionEnter(Collision);
        //Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        transform.position += transform.forward * speed;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }   
      
    }
}