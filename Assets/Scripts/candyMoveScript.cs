using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candyMoveScript : MonoBehaviour
{

    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -7)
        {
            logic.gameOver();
            logic.candyIsAlive = false;
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (logic.candyIsAlive)
        {
            logic.addScore();
            Destroy(gameObject);//destroying the object
        }
    }
}
