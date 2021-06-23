using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playpewsound : MonoBehaviour
{
    public AudioSource Clipd;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Clipd.Play();
        }
    }

}
