using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawn = null;
    public float reloadTime;
    public float inacuracy;
    float currReloadTime;
    float reloadTimeMultiplier;
    float baseReloadTime;
    bool canShoot = true;
    void Start()
    {
        baseReloadTime = reloadTime;
        currReloadTime = reloadTime;
    }
    void Update()
    {
        if (canShoot)
        {
            if (currReloadTime > 0)
            {
                currReloadTime -= Time.deltaTime;
            }
            else
            {
                Disparar();
            }
        }
        else
        {
            reloadTime = baseReloadTime;
        }

    }
    void Disparar ()
    {
        var b = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
        //b.transform.eulerAngles += new Vector3(Random.Range(-inacuracy, inacuracy), Random.Range(-inacuracy, inacuracy), Random.Range(-inacuracy, inacuracy));
        //esta linea esta por si quieren hacer que la bala tenga cierta impresicion
        //en su salida. Solo la roto en x y z al azar
        //en vez de igualarlo, cambiar el valor al que lo igualo por un multiplicador
        currReloadTime = reloadTime;

    }

}