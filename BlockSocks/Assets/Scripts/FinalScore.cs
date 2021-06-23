using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class FinalScore : MonoBehaviour
{
    public Text Scoreeeee;
    
    // Start is called before the first frame update
    void Start()
    {

        Scoreeeee.text = gameManager.thelastscore.ToString();

    }

    // Update is called once per frame
    
    
      

    
}
