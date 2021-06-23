using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{

    public float startTime = 15f;
    public float Timeinterval = 10f;
    public GameObject[] powerUps;
    public Vector2 spawnpoint;


    private void Start()
    {
        InvokeRepeating("SpawnningPowerups", startTime, Timeinterval);
    }
  void SpawnningPowerups()
    {
        int i;
        spawnpoint.x = Random.Range(-6.06f, 5.85f);
        spawnpoint.y = Random.Range(8.79f, 11.85f);

            

        i = Random.Range(0, 4);


        Instantiate(powerUps[i], spawnpoint, Quaternion.identity);

    }
   

}
