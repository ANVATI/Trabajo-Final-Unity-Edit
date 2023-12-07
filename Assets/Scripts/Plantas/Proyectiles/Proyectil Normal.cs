using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    
    public int damage = 1;
    public float speedX;
    public float directionX;
    public int damageAmount = 50;
    private Rigidbody2D _compRigidbody;

    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(speedX * directionX, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Destructor"))
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Zombies"))
        {
            HerenciaZombies zombie = collision.gameObject.GetComponent<HerenciaZombies>();
            if (zombie != null)
            {
                zombie.ReduceLife(damageAmount); 
                Destroy(this.gameObject);
            }
        }
    }
}
