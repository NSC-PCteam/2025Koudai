using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FromResultToSelectChange: MonoBehaviour 
{
    public void OnClick()
    {
        SceneManager.LoadScene("SelectScene");
    }   
}