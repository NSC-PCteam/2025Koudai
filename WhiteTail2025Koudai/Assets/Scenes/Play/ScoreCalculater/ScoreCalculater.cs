using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculater : MonoBehaviour
{
    private int MaxPoint = 900000;
    /*ポイントの満点は900000点、コンボの満点は100000点であり、
    合計100万点満点でポイント、パーセンテージを計算する*/

    public JudgeTest JudgeTest;
    // 入力を取得するスクリプト、本来は塩崎君のスクリプトから取得

    //ノーツの判定数
    private int MissCount = 0;
    private int BadCount = 0;
    private int GoodCount = 0;
    private int ExcellentCount = 0;
    //今のコンボ数
    public int ComboCount = -1;

    //今のポイント
    public static int NowPoint=0;
    //今のレート
    public static int NowRate=0;

    //スコアとコンボの計算で使う文字
    private float SumJudgePoint;
    private float NowComboPoint;
    private float SumComboPoint;

    //スコアの初期化
    void Start()
    {
        NowPoint=0;
        NowRate=0;
    }

    // judgeを引数で受け取る
    public void JudgeNote(int judge)
    {
        //ミスならコンボリセット
        if (judge == 0)
        {
            MissCount++;
            ComboCount = -1;
        }
        else
        //ミス以外はコンボプラス1
        {
            ComboCount++;

            if (judge == 1) BadCount++;
            else if (judge == 2) GoodCount++;
            else if (judge == 3) ExcellentCount++;
        }

        //常にスコアとコンボを更新するための関数呼び出し
        UpdateJudgePoint();
        UpdateComboPoint();

        //今のスコアとパーセンテージを小数点切り捨てで表示
        float NowRealPoint = SumJudgePoint + SumComboPoint;
        NowPoint = (int)NowRealPoint;

        float NowRealRate = (NowPoint / 1000000f) * 100f;
        NowRate = (int)NowRealRate;
    }

    void UpdateJudgePoint()
    {
        //スコア計算
        if (JudgeTest.N > 0)
        {
            SumJudgePoint = MaxPoint / JudgeTest.N *
                (MissCount * 0f + BadCount * 0.3f + GoodCount * 0.7f + ExcellentCount * 1.0f);
        }
    }

    void UpdateComboPoint()
    {

        //コンボ計算
        if (JudgeTest.N > 1 && ComboCount>=0)
        {
            NowComboPoint = 200000f / (JudgeTest.N * (JudgeTest.N - 1));
            SumComboPoint += NowComboPoint * ComboCount;
        }
    }
}