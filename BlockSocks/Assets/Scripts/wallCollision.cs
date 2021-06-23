using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallCollision : MonoBehaviour
{
    public AudioSource collisionsdd;
    public AudioSource theme;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "walla")
        {
            collisionsdd.Play();
            theme.Stop();
            FindObjectOfType<gameManager>().EndGamee();
        }
      
    }
  
    
}

