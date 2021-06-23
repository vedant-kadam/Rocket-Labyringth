using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn1 : MonoBehaviour
{
    public GameObject enemyObj;
    public float timeInterval=2f;
    public float staringtime = 3f;
    public Transform[] trs;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnobj1",staringtime, timeInterval);   
    }

   void spawnobj1()
    {
        int pos = Random.Range(0, trs.Length - 1);
        int pos1 = Random.Range(0, trs.Length - 1);
        
        for (int i = 0; i < trs.Length; i++)
        {
            if(i!=pos&&i!=pos1)
            {
                Instantiate(enemyObj, trs[i].position, Quaternion.identity);
            }

        }

    }
}
