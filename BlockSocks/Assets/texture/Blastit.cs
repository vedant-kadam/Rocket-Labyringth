using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blastit : MonoBehaviour
{
    public AudioSource HitSound;
   
    
    //make the bullet move forward
    
    private void Update()
    {
        

        Destroy(gameObject, 3f);
        
        gameObject.transform.Translate(Vector2.up*Time.deltaTime*8);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            FindObjectOfType<gameManager>().PlaySounds();
          HitSound.Play();
        Destroy(gameObject);
      }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            FindObjectOfType<gameManager>().PlaySounds();
            HitSound.Play();
            Destroy(gameObject);
        }
    }
}
