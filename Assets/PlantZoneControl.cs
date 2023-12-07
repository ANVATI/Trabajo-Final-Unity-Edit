using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantZoneControl : MonoBehaviour
{
    public GameManagerControl gameManager;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        GameObject newPlant = Instantiate(gameManager.currentPlant, transform.position, transform.rotation);
        newPlant.GetComponent<Example>().enabled = false;
        Destroy(gameManager.currentPlant);
        gameManager.currentPlant = null;
    }
}
