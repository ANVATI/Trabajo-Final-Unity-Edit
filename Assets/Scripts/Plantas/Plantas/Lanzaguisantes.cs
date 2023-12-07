using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanzaguisantes : PlantasHerencia
{
    public GameObject bulletPrefab;
    void Start()
    {
        vida = 50; 
        daño = 10;
        InvokeRepeating("InstanciarBala", 15f, 3f);
    }

    void InstanciarBala()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}
