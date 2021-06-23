using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spaningbehaviour : MonoBehaviour
{
    public GameObject enemy;
    public float interval = 2f;
    public float Startspawn = 2f;
    public Transform[] positionOfspawns;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawning", Startspawn, interval);
    }
    void spawning()
    {
        int pos1 =  Random.Range(0, positionOfspawns.Length - 1);
        int posi2 = Random.Range(0, positionOfspawns.Length - 1);
        int posi3 = Random.Range(0, positionOfspawns.Length - 1);
        for (int i = 0; i < positionOfspawns.Length; i++)
        {
            //expcept the given position there our enemy will spawn at all the transform points we specified
            if (i != pos1 && i != posi2 && i != posi3)
            {
                Instantiate(enemy, positionOfspawns[i].position, Quaternion.identity);
            }
        }
    }
   
}
