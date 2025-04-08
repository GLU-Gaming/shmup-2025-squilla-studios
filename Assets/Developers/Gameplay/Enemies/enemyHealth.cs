using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    [SerializeField] private float lives = 1;
 
    [SerializeField] private TextMeshProUGUI ScoreText;
    [SerializeField] public int amount = 100;
 
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name);

        if (other.gameObject.CompareTag("PlayerBullet"))
        {

            lives--;
            Destroy(other.gameObject);
            Debug.Log("Lives remaining: " + lives);

            if (lives <= 0)
            {
                Destroy(gameObject);
                score.AddScore(100);
            }
        }
    }
}
