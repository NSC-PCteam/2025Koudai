using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetScorePointAndRate : MonoBehaviour
{
    public ScoreCalculater ScoreCalculater;

    public TextMeshProUGUI ScoreText;

    public TextMeshProUGUI RateText;

    private static int Score;

    private static int Rate;

    void Start()
    {
        Score = ScoreCalculater.NowPoint;
        ScoreText.text = Score.ToString();

        Rate = ScoreCalculater.NowRate;
        RateText.text = Rate.ToString();
    }
}
