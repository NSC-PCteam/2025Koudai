using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLYCONTLR2 : MonoBehaviour
{
    public Rigidbody2D Rid;
    public float speed = 5.0f;
    public GameObject Player2;
    private bool Player2Mode = false;
    void Start()
    {
        Rid = Player2.GetComponent<Rigidbody2D>();
    }

    void Update()
    {  
        if(Input.GetKeyDown(KeyCode.E))
        {
            Player2Mode = !Player2Mode;
        }

        if(Player2Mode)
        {      
            float move1 = Input.GetAxis("Horizontal"); 

            float move2 = Input.GetAxis("Vertical");

            Rid.velocity = new Vector2(move1 * speed, move2 * speed);
        }
        else
        {
            Rid.velocity = Vector2.zero;
        }
    }
}
