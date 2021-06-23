using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public  int scoreValue=0;
    public Text ScoreO;
  public  static  float   lastValue;
  public  bool ok = true;
    public int upsettime = 30;
    public static int NoOfTimes = 0;

    // Start is called before the first frame update
    void Start()
    {
        ok = true;
        ScoreO.text = 0.ToString();
    }

    // Update is called once per frame
    void Update()
    {
       
        
            StartCoroutine(scoreUPdate());

        


    }
   IEnumerator scoreUPdate()
    {
        yield return new WaitForSeconds(1f);
        
        scoreValue = scoreValue +1;
        float valueofscore = (scoreValue /upsettime)+(NoOfTimes*60);
        ScoreO.text =valueofscore.ToString("0");
        if(ok)
        {
            lastValue = valueofscore;
        }
               
        
       
    }
        
}
