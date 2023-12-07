using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerControl : MonoBehaviour
{
    public MusicControl musicControl;
    public int points;
    public Text TextPoints;
    public GameObject plantPrefab;
    public GameObject currentPlant;

    void Start()
    {
        UpdatePoints(0);
    }

    public void UpdatePoints(int score)
    {
        points = points + score;
        TextPoints.text = "Zombies Eliminados: " + points;
    }
    public void CreatePlant()
    {
        if (currentPlant == null) 
        {
           currentPlant = Instantiate(plantPrefab, transform.position, transform.rotation);

        }
    }
}
