using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWithFixedinterval : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public Transform[] posi;
    public float intervals = 2f;
    public bool ok = true;
    void start()
    {
        
        //after the interval specified the function to spawn will be called
        //currently i am a noob trying to learn things so i cant really explain it welll
        //bb it does something like that
        StartCoroutine(FunctionTospawn());
    }
    


    IEnumerator FunctionTospawn()
    {
        while (ok)
        {


            yield return new WaitForSeconds(intervals);

            //out of the spawn points it will select random one 
            int pos1 = Random.Range(0, posi.Length - 1);
            int posi2 = Random.Range(0, posi.Length - 1);
            int posi3 = Random.Range(0, posi.Length - 1);
            for (int i = 0; i < posi.Length; i++)
            {
                //expcept the given position there our enemy will spawn at all the transform points we specified
                if (i != pos1 && i != posi2 && i != posi3)
                {
                    Instantiate(EnemyPrefab, posi[i].position, Quaternion.identity);
                }
            }


        }
    }


}
