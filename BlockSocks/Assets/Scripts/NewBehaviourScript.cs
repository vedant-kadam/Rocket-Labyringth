using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioSource grede;
    public ParticleSystem Burst;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Burst.Play();
            FindObjectOfType<gameManager>().EndGamee();
            grede.Play();
            
        }
    }
}
