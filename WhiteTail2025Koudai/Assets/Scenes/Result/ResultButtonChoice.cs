
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UI使うときに必要
using UnityEngine.UI;

public class ResultButtonChoice : MonoBehaviour
{
    public Button button;

    void Start()
    {
        button = GameObject.Find("ResultCanvas/ButtonSummary/Button").GetComponent<Button>();
        //ボタンが選択された状態になる
        button.Select();
    }
}