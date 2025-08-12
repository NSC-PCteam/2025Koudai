using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera1chase : MonoBehaviour
{ 
    public GameObject player1;
    public GameObject player2;
    private Vector3 offset1;
    private Vector3 offset2;
    public Camera Camera1;
    private bool Player2Mode = false;
	void Start()
    {    
        
        offset1 = Camera1.transform.position - player1.transform.position;
        
        offset2 = Camera1.transform.position - player2.transform.position;
	}

	void LateUpdate()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Player2Mode = !Player2Mode;
            
        }
        GameObject targetPlayer = Player2Mode ? player2 : player1;

        Camera1.transform.position = targetPlayer.transform.position + (Player2Mode ? offset2 : offset1);
    }
}
	
