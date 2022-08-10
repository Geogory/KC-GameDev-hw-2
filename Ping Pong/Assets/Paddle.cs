using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    
    Rigidbody2D RB;
    private float movement;
    

    // Start is called before the first frame update
    void Start()
    {

        RB = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxis("Vertical1");
        }
        else
        {
            movement = Input.GetAxis("Vertical2");
        }
       
        RB.velocity = new Vector2(RB.velocity.x,movement * speed);
    }
}
