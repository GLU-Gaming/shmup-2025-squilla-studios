using UnityEngine;
using UnityEngine.SceneManagement;

public class Bosshealth : MonoBehaviour
{
    public float bosshealth = 100;

    void OnTriggerEnter(Collider other)
    {
       // Debug.Log("Collision detected with: " + other.gameObject.name);

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player collision detected");
            bosshealth--;
            Debug.Log("remaining: " + bosshealth);

            if (bosshealth <= 0)
            {
                
                gameObject.SetActive(false);
            
            }
        }
    }
}
