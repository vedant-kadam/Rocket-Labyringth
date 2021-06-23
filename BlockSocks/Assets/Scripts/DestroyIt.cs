using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIt : MonoBehaviour
{
    public float timeFactor = 20f;
    void start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / timeFactor;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Destroyer")
        {
            Destroy(gameObject);
        }
    }

}
