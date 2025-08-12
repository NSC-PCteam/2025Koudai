using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLYCHNG2 : MonoBehaviour
{
    //public Camera camera1;
    //public BoxCollider2D collider;
    public PLYCONTLR plcon1;
    public PLYCONTLR2 plcon2;
    //public Rigidbody2D r2d;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            //sr = GetComponent<SpriteRenderer>();
            //sr.material.color = sr.material.color - new Color32(0,0,0,255);
            //chase.gameObject.SetActive(true);
            //camera1.gameObject.SetActive(true);
            //collider.gameObject.SetActive(true);
            plcon1.gameObject.SetActive(true);
            //plcon2.gameObject.SetActive(false);
            //r2d.gameObject.SetActive(true);
        }
    }
}