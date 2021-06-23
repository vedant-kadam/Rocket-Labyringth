using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementusingforces : MonoBehaviour
{
    public float forcex=10f;
    Rigidbody2D rb;
    Vector2 pos;
    float xx;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {
        xx = Input.GetAxis("Horizontal");
    }
    void fixedUpdate()
    {
        Debug.Log("left");
       
        rb.AddForce(xx*transform.right * forcex, ForceMode2D.Force);
    }
  
}
