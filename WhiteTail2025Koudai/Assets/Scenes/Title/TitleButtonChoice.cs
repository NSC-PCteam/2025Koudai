using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleButtonChoice : MonoBehaviour
{
    public Button button;

    void Start()
    {
        //ボタンが選択された状態になる
        button.Select();
    }
}