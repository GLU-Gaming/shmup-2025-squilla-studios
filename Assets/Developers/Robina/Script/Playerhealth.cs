using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerhealth : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float lives = 3;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name);

        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy collision detected");
            lives--;
            Debug.Log("Lives remaining: " + lives);

            if (lives <= 0)
            {
                Debug.Log("Game Over");
                gameObject.SetActive(false);
                SceneManager.LoadScene("GameOverScene");
            }
        }
    }
}
