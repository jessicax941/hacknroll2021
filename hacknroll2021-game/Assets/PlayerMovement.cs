using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Joystick joystick;
    public float speed = 5f;

    private float startingX = 12.5f;
    private float startingY = 13.2f;
    private float minX = 10.87f;
    private float maxX = 23.5f;
    private float minY = 8.67f;
    private float maxY = 17.74f;
    private float horizontalMove = 0f;
    private float verticalMove = 0f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.position = new Vector2(startingX, startingY); // set starting position
    }

    // Update is called once per frame
    void Update()
    {
        if (joystick.Horizontal > .5f)
        {
            horizontalMove = speed;
        } else if (joystick.Horizontal < -.5f)
        { 
            horizontalMove = -speed;
        } else
        {
            horizontalMove = 0f;
        }

        if (joystick.Vertical > .5f)
        {
            verticalMove = speed;
        } else if (joystick.Vertical < -.5f)
        {
            verticalMove = -speed;
        } else
        {
            verticalMove = 0f;
        }

        Vector2 velocity = new Vector2(horizontalMove, verticalMove);

        if ((minX <= rb.position.x) && (rb.position.x <= maxX) && (minY <= rb.position.y) && (rb.position.y <= maxY))
        {
            rb.velocity = velocity;
        } else
        {
            // outside of boundary, stop player movement
            rb.velocity = new Vector2(0, 0);

            // reset player's position if exceed boundary
            if (rb.position.x < minX)
            {
                rb.MovePosition(new Vector2(minX, rb.position.y));
            }
            if (rb.position.x > maxX)
            {
                //rb.position.x = maxX;
                rb.MovePosition(new Vector2(maxX, rb.position.y));
            }
            if (rb.position.y < minY)
            {
                //rb.position.y = minY;
                rb.MovePosition(new Vector2(rb.position.x, minY));
            }
            if (rb.position.y > maxY)
            {
                //rb.position.y = maxY;
                rb.MovePosition(new Vector2(rb.position.x, maxY));
            }

        }
        
    }
}
