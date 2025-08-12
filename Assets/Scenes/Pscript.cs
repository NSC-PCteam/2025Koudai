using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pscript : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    private Vector3 offset1;
    private Vector3 offset2;
    public Camera Camera1;
    public Rigidbody2D Rid1;
    public Rigidbody2D Rid2;
    public float speed1 = 5.0f;
    public float speed2 = 5.0f;
    public float speed3 = 10.0f;
    private bool Player2Mode = false;
    private bool isGrounded = false;
    public Animator anim;

    void Start()
    {
        offset1 = Camera1.transform.position - Player1.transform.position;
        offset2 = Camera1.transform.position - Player2.transform.position;
        Player2.SetActive(false);
        Rid1 = Player1.GetComponent<Rigidbody2D>();
        Rid2 = Player2.GetComponent<Rigidbody2D>();
        anim = Player1.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Player2Mode = !Player2Mode;

            if (Player2Mode)
            {
                Player2.SetActive(true);
                Player2.transform.position = Player1.transform.position;
            }
            else
            {
                Player2.SetActive(false);
            }
        }

        GameObject targetPlayer = Player2Mode ? Player2 : Player1;
        Camera1.transform.position = targetPlayer.transform.position + (Player2Mode ? offset2 : offset1);

        if (Player2Mode)
        {
            float move1 = Input.GetAxis("Horizontal");
            float move2 = Input.GetAxis("Vertical");
            Rid2.velocity = new Vector2(move1 * speed2, move2 * speed2);
        }
        else
        {
            float move3 = Input.GetAxis("Horizontal");
            float move4 = Input.GetAxis("Vertical");
            Rid1.velocity = new Vector2(move3 * speed1, move4 * speed1);
            if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                anim.SetBool("right", true);
                anim.SetBool("front", false);
                anim.SetBool("left", false);
                anim.SetBool("back", false);
            }

            if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
            {
                anim.SetBool("right", false);
            }

            if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                anim.SetBool("left", true);
                anim.SetBool("front", false);
                anim.SetBool("right", false);
                anim.SetBool("back", false);
            }

            if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
            {
                anim.SetBool("left", false);
            }

            if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                anim.SetBool("left", false);
                anim.SetBool("right", false);
                anim.SetBool("back", false);
                if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                {
                    anim.SetBool("front", false);
                    anim.SetBool("runfront", true);
                    float move5 = Input.GetAxis("Vertical");
                    Rid1.velocity = new Vector2(move3 * speed1, move5 * speed3);
                }
                else
                {
                    anim.SetBool("runfront", false);
                    anim.SetBool("front", true);
                }
            }
            else
            {
                anim.SetBool("runfront", false);
            }

            if(Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
            {
                anim.SetBool("runfront", false);
                anim.SetBool("front", true);
            }

            if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
            {
                anim.SetBool("front", false);
            }

            if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                anim.SetBool("front", false);
                anim.SetBool("left", false);
                anim.SetBool("right", false);
                anim.SetBool("back", true);
            }

            if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow))
            {
                anim.SetBool("back", false);
            }

            if(Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.DownArrow))
            {
                anim.SetBool("frontright", true);
            }

            if(Input.GetKeyUp(KeyCode.D) && Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.RightArrow) && Input.GetKeyUp(KeyCode.DownArrow))
            {
                anim.SetBool("frontright", false);
            }

            if(Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.DownArrow))
            {
                anim.SetBool("frontleft", true);
            }

            if(Input.GetKeyUp(KeyCode.A) && Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.LeftArrow) && Input.GetKeyUp(KeyCode.DownArrow))
            {
                anim.SetBool("frontleft", false);
            }

            if(Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.RightArrow))
            {
                anim.SetBool("backright", true);
            }

            if(Input.GetKeyUp(KeyCode.W) && Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.UpArrow) && Input.GetKeyUp(KeyCode.RightArrow))
            {
                anim.SetBool("backright", false);
            }

            if(Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.LeftArrow))
            {
                anim.SetBool("backleft", true);
            }

            if(Input.GetKeyUp(KeyCode.W) && Input.GetKeyUp(KeyCode.A)|| Input.GetKeyUp(KeyCode.UpArrow) && Input.GetKeyUp(KeyCode.LeftArrow))
            {
                anim.SetBool("backleft", false);
            }
        }
    }
}