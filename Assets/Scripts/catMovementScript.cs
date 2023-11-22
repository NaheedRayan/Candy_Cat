using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catMovementScript : MonoBehaviour
{

   
    public float speed = 1 ;
    public bool catCanMove = true;

  

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

       
        if (catCanMove)
        {
            float horizontalValue = Input.GetAxisRaw("Horizontal");
            moveCat(horizontalValue);
        }

    }

    void moveCat(float x)
    {

        // Calculate the new position based on the input and speed
        //float newPosition = transform.position.x + x * speed * Time.deltaTime;

        // Clamp the new position to stay within the specified constraints
        //newPosition = Mathf.Clamp(newPosition, -7f, 7f);


        transform.position += new Vector3(x, 0,0) * Time.deltaTime * speed;
        float newPos = Mathf.Clamp(transform.position.x, -7f, 7f);


        // Update the object's position
        transform.position = new Vector3(newPos, transform.position.y, transform.position.z);
    }
}
