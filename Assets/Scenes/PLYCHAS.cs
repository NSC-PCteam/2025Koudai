using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLYCHAS : MonoBehaviour
{
    public GameObject Player2;
    public GameObject Player1;
    private bool Player2Mode = false;
    void Start()
    {
        Player2.SetActive(false);
        Player1.SetActive(true);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Player2Mode = !Player2Mode;
        }

        if(Player2Mode)
        {
            Player2.SetActive(true);
            Player1.SetActive(true);
            Player2.transform.position = Player1.transform.position;
        }
        else
        {
            Player2.SetActive(false);
            Player1.SetActive(true);
        }
    }
}