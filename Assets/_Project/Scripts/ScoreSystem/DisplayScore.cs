using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText, _highScoreText;

    public void UpdateScore(int value)
    {
        _scoreText.text = "Score: " + value.ToString();
    }
    public void UpdateHighScore(int value)
    {
        _highScoreText.text = "High Score: " + value.ToString();
    }
}