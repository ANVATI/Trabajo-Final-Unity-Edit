using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerenciaZombies : MonoBehaviour
{
    public int life = 50;
    public int damage = 1;
    public float speedX = 1;
    public float directionX = -1;
    private Rigidbody2D _compRigidbody;
    public GameManagerControl gameManager;

    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(speedX * directionX, 0);
    }

    public void ReduceLife(int amount)
    {
        life = life - amount;
        if (life <= 0)
        {
            gameManager.UpdatePoints(1);
            Destroy(gameObject);
        }
    }
   
    public void SetGameManager(GameManagerControl gm)
    {
        gameManager = gm;
    }

}
