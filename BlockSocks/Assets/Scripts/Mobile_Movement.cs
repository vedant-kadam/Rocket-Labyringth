using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobile_Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed=10f;
    Vector2 pos;
    

    // Update is called once per frame
    void Update()
    {
       
       pos.x  = Input.GetAxis("Horizontal");
        pos.y = 0f;
        
    }
    private void FixedUpdate()
    {

        rb.MovePosition(rb.position + pos * speed * Time.fixedDeltaTime);


    }


}
