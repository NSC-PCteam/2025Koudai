using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FromSelectToPlayChange: MonoBehaviour 
{
    public void OnClick()
    {
        SceneManager.LoadScene("PlayScene");
    }   
}