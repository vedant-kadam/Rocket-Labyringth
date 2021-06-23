using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foloow : MonoBehaviour
{
   public Transform Player;
    public Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       



        gameObject.transform.position = Player.position + offset;
    }
}
