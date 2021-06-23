using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyBlastSound : MonoBehaviour
{
    public AudioSource BAlst;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            BAlst.Play();
        }
    }
}
