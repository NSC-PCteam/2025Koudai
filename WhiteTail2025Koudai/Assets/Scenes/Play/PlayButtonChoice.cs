using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButtonChoice : MonoBehaviour
{
    public Button button;

    void Start()
    {
        button = GameObject.Find("PlayCanvas/ButtonSummary/Button").GetComponent<Button>();
        //ボタンが選択された状態になる
        button.Select();
    }
}