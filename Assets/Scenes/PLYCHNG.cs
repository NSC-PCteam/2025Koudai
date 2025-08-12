using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLYCHNG : MonoBehaviour
{
    //public Camera camera1;
    //public Camera camera2;
    //public GameObject Player2;
    //public BoxCollider2D collider;
    public PLYCONTLR plcon1;
    public PLYCONTLR2 plcon2;
    //public Rigidbody2D r2d;
    private bool Player2Mode = false;

    void Start()
    {
        //camera2.gameObject.SetActive(false);
        //Player2.gameObject.SetActive(false);
        //plcon2.gameObject.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Player2Mode = !Player2Mode;
        }

        if(Player2Mode)
        {   
            //sr = GetComponent<SpriteRenderer>();
            //sr.material.color = sr.material.color - new Color32(0,0,0,0);
            //chase.gameObject.SetActive(false);
            //camera1.gameObject.SetActive(false);
            //collider.gameObject.SetActive(false);
            //Player2.gameObject.SetActive(true);
            //camera2.gameObject.SetActive(true);
            plcon1.gameObject.SetActive(false);
            //plcon2.gameObject.SetActive(true);
            //r2d.gameObject.SetActive(false);
        }

        if(!Player2Mode)
        {
            plcon1.gameObject.SetActive(true);
        }
    }
}
