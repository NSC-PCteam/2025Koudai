using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FromPlayToResultChange: MonoBehaviour 
{
    public void OnClick()
    {
        // 現在のシーン名を保存
        SceneSave.previousSceneName = SceneManager.GetActiveScene().name;

        SceneManager.LoadScene("ResultScene");
        
    }   
}