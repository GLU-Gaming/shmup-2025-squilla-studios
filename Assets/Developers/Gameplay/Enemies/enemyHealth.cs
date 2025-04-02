using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    [SerializeField] private float lives = 1;
    [SerializeField] public int score;
    [SerializeField] private TextMeshProUGUI ScoreText;
    [SerializeField] public int amount = 100;
    void Start()
    {
        score = 0;
        ScoreText.text = "Score: " + score;
    }


    void Update()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Player"))
        {

            lives--;
            Debug.Log("Lives remaining: " + lives);

            if (lives <= 0)
            {
                Destroy(gameObject);
                score += 100;
                ScoreText.text = "Score: " + score;
            }
        }
    }
}
