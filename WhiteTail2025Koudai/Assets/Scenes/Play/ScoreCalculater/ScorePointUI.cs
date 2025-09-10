using TMPro;
using UnityEngine;

public class ScorePointUI : MonoBehaviour
{
    public ScoreCalculater ScoreCalculater;

    public TextMeshProUGUI ScoreText;

    private int Point;

    void Start()
    {
        Point = ScoreCalculater.NowPoint;
    }

    void Update()
    {
        Point = ScoreCalculater.NowPoint;
        ScoreText.text=Point.ToString();
    }
}
