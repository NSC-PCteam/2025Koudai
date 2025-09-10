using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FromTitleToSettingChange: MonoBehaviour 
{
    public void OnClick()
    {
        SceneManager.LoadScene("SettingScene");
    }   
}