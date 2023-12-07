using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantasHerencia: MonoBehaviour
{
    protected int vida;
    protected int da�o;

    public virtual void ConfigurarVidaDa�o(int vidaBase, int da�oBase)
    {
        vida = vidaBase;
        da�o = da�oBase;
    }

    public virtual void Atacar()
    {
        Debug.Log("Ataque gen�rico de planta.");
    }

    public void RecibirDa�o(int cantidadDa�o)
    {
        vida = vida - cantidadDa�o;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
