using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonWithTheplayer : MonoBehaviour
{
    public AudioSource Grenade;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Grenade.Play();

            FindObjectOfType<gameManager>().EndGamee();
        }
    }
}
