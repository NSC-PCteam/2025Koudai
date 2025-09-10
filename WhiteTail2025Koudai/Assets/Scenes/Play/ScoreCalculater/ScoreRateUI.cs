using TMPro;
using UnityEngine;

public class ScoreRateUI : MonoBehaviour
{
    public ScoreCalculater ScoreCalculater;

    public TextMeshProUGUI ScoreText;

    private int Rate;

    void Start()
    {
        Rate = ScoreCalculater.NowRate;
    }

    void Update()
    {
        Rate = ScoreCalculater.NowRate;
        ScoreText.text=Rate.ToString();
    }
}
