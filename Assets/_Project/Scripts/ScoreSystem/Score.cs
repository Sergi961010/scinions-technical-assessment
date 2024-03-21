using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private DisplayScore _displayScore;
    private int _score = 0, _highScore;
    private void Awake()
    {
        _highScore = PlayerPrefs.GetInt("HighScore", 0);
    }
    private void OnEnable()
    {
        CoinController.OnCoinCollected += ChangeScore;
    }
    private void OnDisable()
    {
        CoinController.OnCoinCollected -= ChangeScore;
    }
    private void ChangeScore(int value)
    {
        _score += value;
        if (_score > _highScore)
        {
            _highScore = _score;
            _displayScore.UpdateHighScore(_highScore);
        }
        _displayScore.UpdateScore(_score);
    }
}