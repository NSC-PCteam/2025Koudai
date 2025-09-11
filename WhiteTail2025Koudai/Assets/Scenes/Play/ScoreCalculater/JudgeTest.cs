using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//スコア計算のテスト
public class JudgeTest : MonoBehaviour
{
    public ScoreCalculater ScoreCalculater;

    public int N;//総ノーツ数

    public int Judge;//ノーツの判定

    void Update()
    {
        //ボタンでノーツの判定を出す
        if(Input.GetKeyDown(KeyCode.F)) 
        {
            Judge=0;
            ScoreCalculater.JudgeNote(Judge);
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            Judge=1;
            ScoreCalculater.JudgeNote(Judge);
        }

        if(Input.GetKeyDown(KeyCode.H))
        {
            Judge=2;
            ScoreCalculater.JudgeNote(Judge);
        }

        if(Input.GetKeyDown(KeyCode.J))
        {
            Judge=3;
            ScoreCalculater.JudgeNote(Judge);
        }
    }
}
