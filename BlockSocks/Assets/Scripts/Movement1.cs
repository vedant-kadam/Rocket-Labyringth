using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
   public static  float Speed ;
    Rigidbody2D rb;
    Vector2 positionToClamp;
    float screenWidth;
    public   float lastmove;
    public float allowedTimeToStay=5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        screenWidth = Screen.width;
        Speed = 9f;
    }

    // Update is called once per frame
    void Update()
    {
        float diff = Time.timeSinceLevelLoad - lastmove;
        if(diff>5f)
        {
            //endgame
            lastmove = -1f;
            FindObjectOfType<gameManager>().EndGamee();
        }
        if(Input.GetAxis("Horizontal")>0)
        {
            moveRight();
            
        }
        if(Input.GetAxis("Horizontal")<0)
        {
            moveLeft();
           
        }
        if(Input.GetTouch(0).position.x > screenWidth/2)
        {
            moveRight();
            
        }
        if(Input.GetTouch(0).position.x < screenWidth/2)
        {
            moveLeft();
           
        }
        if(Input.GetTouch(0).position.x > screenWidth / 2 && Input.GetTouch(1).position.x < screenWidth / 2)
        {
            gameObject.transform.Translate(Vector2.up * Time.deltaTime);

        }

      

        if (gameObject.transform.position.x > 6.7f)
        {
           
            FindObjectOfType<gameManager>().EndGamee();
        }
        if (gameObject.transform.position.x < -6.65f)
        {

            FindObjectOfType<gameManager>().EndGamee();
        }




    }
    public void moveLeft()
    {
        positionToClamp = transform.right * -Speed * Time.deltaTime + transform.position;
        positionToClamp.y = Mathf.Clamp(positionToClamp.y, -5.18f, 5f);
        positionToClamp.x = Mathf.Clamp(positionToClamp.x, -6.92f, 7f);
        transform.position = positionToClamp;

       
        lastmove = Time.timeSinceLevelLoad;
    }
    public void moveRight()
    {
        positionToClamp = transform.right * Speed * Time.deltaTime + transform.position;
        positionToClamp.y = Mathf.Clamp(positionToClamp.y, -5.18f, 5f);
        positionToClamp.x = Mathf.Clamp(positionToClamp.x, -6.92f, 7f);
        transform.position = positionToClamp;
        
        lastmove = Time.timeSinceLevelLoad;

    }
}
