using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLYCONTLR : MonoBehaviour
{
    public Rigidbody2D Rid;
    public float speed = 5.0f;
    public GameObject Player1;
    void Start()
    {
        Rid = Player1.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Player1.gameObject.activeSelf)
        {
            float move = Input.GetAxis("Horizontal");

            Rid.velocity = new Vector2(move * speed, Rid.velocity.y);  
        } 
    }

    void OnCollisionStay2D(Collision2D collision) 
    {
        if(Player1.gameObject.activeSelf)
        {
            if(collision.gameObject.CompareTag("Block"))
            {
                if(Input.GetKeyDown(KeyCode.W))
                {
                    Rid.AddForce(new Vector2(0.0f, 5.0f), ForceMode2D.Impulse);
                }
        
                if(Input.GetKeyDown(KeyCode.UpArrow))
                {
                    Rid.AddForce(new Vector2(0.0f, 5.0f), ForceMode2D.Impulse);
                }
            }
        }
    }
}
