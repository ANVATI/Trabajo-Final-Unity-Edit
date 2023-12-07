using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repetidora : PlantasHerencia
{
    public GameObject bulletPrefab;

    void Start()
    {
        vida = 80;
        daño = 15;
        InvokeRepeating("InstanciarBala", 15f, 3f);
    }

    void InstanciarBala()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }

}

