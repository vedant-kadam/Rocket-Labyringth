using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovement : MonoBehaviour
{
    public float speed = 2f;
    Rigidbody2D rb;
    public float offset = 10f;
    
   
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
       
 
    }

    // Update is called once per frame
   public void Update()
    {
        if( Input.GetKey(KeyCode.A)|| Input.GetButton("Fire1"))
        {

            MoveLeft();

        }
        
        if ( Input.GetKey(KeyCode.D)||Input.GetButton("Fire2"))
        {

            MoveRight();

        }
        
        



    }
   public void MoveLeft()
    {
        Debug.Log("right presed");
        float Xcordinate = -speed * Time.deltaTime;
        Vector3 positionD = gameObject.transform.position + transform.right * Xcordinate;


        positionD.x = Mathf.Clamp(positionD.x, 32.5f,14.34f);
        positionD.y = Mathf.Clamp(positionD.y, -6f, 0f);
        gameObject.transform.position = positionD;
    }
   public void MoveRight()
    {
        Debug.Log("leftPressed");
        ;
        float Xcordinate = speed * Time.deltaTime;
        Vector3 positionD = gameObject.transform.position + transform.right * Xcordinate;


        positionD.x = Mathf.Clamp(positionD.x, 32.5f, 14.34f); 
        positionD.y = Mathf.Clamp(positionD.y, -6f, 0f);
        gameObject.transform.position = positionD;
    }

    public void StayPut()
    {
        gameObject.transform.position = gameObject.transform.position;
    }
}
