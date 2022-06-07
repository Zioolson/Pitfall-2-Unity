using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public Joystick joystick;
    
    public float speed = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        float vert = joystick.Vertical;
        float verth = joystick.Horizontal;
        if (collision.tag == "Player" && vert >= .5f)
        {
            collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        }
        else if (collision.tag == "Player" && vert <= .5f)
        {
            collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        }
        else if(verth == 0)
        {
            collision.GetComponent<Rigidbody2D>().gravityScale = 0.0f;
        }
        else
        {
            collision.GetComponent<Rigidbody2D>().gravityScale = 1.0f;
        }
        Debug.Log(verth);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

    }
}
