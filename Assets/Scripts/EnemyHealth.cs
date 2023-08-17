using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int health;
    // Start is called before the first frame update
    void Start()
    {
        health = PersistentData.enemyHealthPoints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            //morir
            Death();
        }
    }

    private void Death()
    {
        Destroy(gameObject);
        //sonido
        //animacion
        //restar una vida
        //sumar un punto
    }
}
