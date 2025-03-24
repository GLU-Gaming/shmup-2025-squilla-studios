using Unity.VisualScripting;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    [SerializeField] private float lives = 1;
    void Start()
    {
        
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
            }
        }
    }
}
