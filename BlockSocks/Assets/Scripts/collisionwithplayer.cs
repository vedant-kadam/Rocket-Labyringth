﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionwithplayer : MonoBehaviour
{
    public AudioSource grenade;
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            grenade.Play();
            Destroy(gameObject);
        }
        else if(collision.gameObject.tag=="Bullet")
        {
            
            Destroy(gameObject);
            

        }
    }
}
