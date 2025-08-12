using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Camera2case : MonoBehaviour {
 
    private GameObject player;
    private Vector3 offset;
	void Start () 
    {    
        this.player = GameObject.Find("Player2");
        offset = transform.position - player.transform.position;
	}

	void Update () 
    {
        transform.position = player.transform.position + offset;
	}
}