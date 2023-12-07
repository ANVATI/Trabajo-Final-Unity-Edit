using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantasHerencia: MonoBehaviour
{
    protected int vida;
    protected int daño;

    public virtual void ConfigurarVidaDaño(int vidaBase, int dañoBase)
    {
        vida = vidaBase;
        daño = dañoBase;
    }

    public virtual void Atacar()
    {
        Debug.Log("Ataque genérico de planta.");
    }

    public void RecibirDaño(int cantidadDaño)
    {
        vida = vida - cantidadDaño;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
