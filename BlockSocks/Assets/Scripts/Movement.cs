using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movement : MonoBehaviour
{
  
    public float speed = 10f;
    public float offset=3f;
         
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {


            float x = -speed * Time.deltaTime;


            Vector3 pos = gameObject.transform.position + (Vector3.right * x);
            pos.x = Mathf.Clamp(pos.x, -offset, offset);

            gameObject.transform.position = pos;

        }

        if (Input.GetButton("Fire2"))
        {


            float x = speed * Time.deltaTime;


            Vector3 pos = gameObject.transform.position + (Vector3.right * x);
            pos.x = Mathf.Clamp(pos.x, -offset, offset);

                gameObject.transform.position = pos;
        }
    }
}
