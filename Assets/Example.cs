using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    //public GameObject zombie;
    void Start()
    {
        
    }
    void Update()
    {
        Vector2 trueposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = trueposition;
    }
}
