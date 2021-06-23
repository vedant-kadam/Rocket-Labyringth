using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootationLimiter : MonoBehaviour
{
    public GameObject Liniy;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.rotation = Liniy.transform.rotation;
       

    }
}
