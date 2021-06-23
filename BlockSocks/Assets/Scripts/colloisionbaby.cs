using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class colloisionbaby : MonoBehaviour
{
    //scripts runs when there is a colloision
    public AudioSource deathSound;
    public AudioSource Theme;
    public ParticleSystem burs;
    float Initialtime;
    public bool colllisonOn = true;
    public Camera cam;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (colllisonOn)
        {
            if (collision.gameObject.tag == "Enemy")
            {
               cam.GetComponent<AudioSource>().Play();
                Theme.Stop();
                deathSound.Play();
           
                Instantiate(burs, gameObject.transform.position, Quaternion.identity);
                Destroy(gameObject);

                //it is uded to  just fing the object and run the script when the event occur
                FindObjectOfType<gameManager>().EndGamee();
            }
        }
     if(collision.gameObject.tag =="invinsible")
        {
            FindObjectOfType<gameManager>().Invinsibility();
           
        }
     if(collision.gameObject.tag=="WALLS")
        {
           cam.GetComponent<AudioSource>().Play();
            Theme.Stop();
            deathSound.Play();
            Destroy(gameObject);
            Instantiate(burs, gameObject.transform.position, Quaternion.identity);


            //it is uded to  just fing the object and run the script when the event occur
            FindObjectOfType<gameManager>().EndGamee();
        }
       /* if (collision.gameObject.tag == "Speed")
       {
            FindObjectOfType<gameManager>().speed();

        }*/
    }
   

}

