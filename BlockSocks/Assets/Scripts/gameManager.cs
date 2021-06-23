using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public float SLowDownFactor = 10f;

    public static float thelastscore;


    bool hit =false;
    bool hitSpeed = false;
    float hitTime;
    float HitSpeedTime;
    public GameObject PlayerBody;
    float CurrTime;
    bool TimeHit = false;
    public GameObject ScoreTextToCcge;
    bool firingStart = false;
    float FiringStarttime;
    public GameObject bulletToFire;
    public GameObject FiringPosition;
    float TimeBetweenInstantiation;
    public AudioSource BlastBetBulletAndRock;

    //public Camera cammm;


    public void EndGamee()
    {

       // cammm.GetComponent<AudioSource>().Play();
        StartCoroutine(RestartLevel());
       
    }

     IEnumerator RestartLevel()
    {
        
        Time.timeScale = 1 / SLowDownFactor;
        Time.fixedDeltaTime = Time.fixedDeltaTime / SLowDownFactor;
     
        yield return new WaitForSeconds(1f/SLowDownFactor);
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * SLowDownFactor;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        FindObjectOfType<ScoreScript>().ok = false;
        FindObjectOfType<ScoreScript>().enabled = false;

        thelastscore = ScoreScript.lastValue +1;
    



    }
    public void QUiteIt()
    {
        Application.Quit();
       
    }

    public void MainLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void restart()
    {
        FindObjectOfType<Spannners>().timetosap =Time.time + 3f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
       
    }
    public void Invinsibility()
    {
         hitTime = Time.time;
         hit = true;
        

    }
    public void speed()
    {
        HitSpeedTime = Time.time;
        hitSpeed = true;
    }
    private void Start()
    {
        hit = false;
    }
    private void Update()
    {
        if(hit)
        {
            if(Time.time-hitTime < 5f)
            {
                PlayerBody.GetComponent<BoxCollider2D>().isTrigger = true;
            }else
            {
                PlayerBody.GetComponent<BoxCollider2D>().isTrigger = false;
                hit = false;
            }

        }
        if(hitSpeed)
        {
            if(Time.time -HitSpeedTime<5f)
            {
                Movement1.Speed = 20f;
            }else
            {
              Movement1.Speed = 9f;
                hitSpeed = false;
            }

        }
        if(TimeHit)
        {
            if(Time.time - CurrTime<8)
            {
                ScoreTextToCcge.GetComponent<ScoreScript>().upsettime = 5;

            }
            else
            {
                ScoreScript.NoOfTimes += 1;
                ScoreTextToCcge.GetComponent<ScoreScript>().upsettime = 30;
                TimeHit = false;

            }

        }
        if(firingStart)
        {
            if(Time.time - FiringStarttime <6)
            {
                if (Time.time - TimeBetweenInstantiation > 0.3)
                {
                    Instantiate(bulletToFire, FiringPosition.transform.position, Quaternion.identity);
                    TimeBetweenInstantiation = Time.time;
                }
            }
        }
       
       
    }
   
    public void ScoreX2()
    {
        CurrTime = Time.time;
        TimeHit = true;

    }
    public void Shoot()
    {
        FiringStarttime = Time.time;
        firingStart = true;
        TimeBetweenInstantiation = Time.time-0.2f;

    }
    public void PlaySounds()
    {
        BlastBetBulletAndRock.Play();

    }

}
