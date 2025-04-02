using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ScoreText;

    private int score;
    void Start()
    {
        score = 0;
        ScoreText.text = "Score: " + score;
    }

    public void AddScore(int amount)
    {
        score = score + amount;

        ScoreText.text = "Score: " + score;
    }
}