using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FromResultToPlayChange: MonoBehaviour 
{
    public void OnClick()
    {
        GoBack();
        //SceneManager.LoadScene("PlayScene");
    }

    public void GoBack()
    {
        if (!string.IsNullOrEmpty(SceneSave.previousSceneName))
        {
            SceneManager.LoadScene(SceneSave.previousSceneName);
        }
    }
}