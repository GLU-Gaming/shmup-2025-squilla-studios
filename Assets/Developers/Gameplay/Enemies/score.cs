using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    [SerializeField] private int Score;
    [SerializeField] private TextMeshProUGUI scoreText;

    private static score instance;

    void Start()
    {
        UpdateScoreText();
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        // Example of how to update the score
        // This should be replaced with actual game logic
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddScore(10);
        }
    }

    public static void AddScore(int amount)
    {
        if (instance == null)
        {
            instance = FindFirstObjectByType<score>();
        }
        instance.Score += amount;
        instance.UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = " " + Score;
        }
        else
        {
            Debug.LogError("Score TextMeshProUGUI component is not assigned.");
        }
    }
}