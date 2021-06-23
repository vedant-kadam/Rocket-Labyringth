using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spannners : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject blockPrefab;
    public float timetosap = 2f;
    public float interval = 1f;


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
        if (Time.time >= timetosap)
        {
            spawnBaby();
            timetosap = Time.time + interval;
        }
    }
    void spawnBaby()
    {
        int randomNo1,randomNo2;
        //we are choosing a random number
        randomNo1 = Random.Range(0, spawnPoints.Length -1);
        randomNo2 = Random.Range(0, spawnPoints.Length - 1);
        //then running a for loop to creat the no of objects
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            //if the randomly picked number is not i then if  statement will run
            if(i != randomNo1 && i != randomNo2 )
            {//now we instantiate tghew objects
                //by using instantiate its takes 2 argyuments by default
                //it6s can also take 3 that may vary ..but currently i am a nnob and i dont know a lot about it
             Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);

            }
        }

    }
}
